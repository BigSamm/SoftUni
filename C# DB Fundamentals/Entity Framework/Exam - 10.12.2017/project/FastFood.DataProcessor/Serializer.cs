namespace FastFood.DataProcessor
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using Newtonsoft.Json;

    using Data;
    using Dto.Export;
    using Models.Enums;

    public class Serializer
	{
		public static string ExportOrdersByEmployee(FastFoodDbContext context, string employeeName, string orderType)
		{
            OrderType type = Enum.Parse<OrderType>(orderType);

            var employee = context.Employees
                .Where(e => e.Name == employeeName)
                .Select(e => new EmployeeDto
                {
                    Name = e.Name,
                    Orders = e.Orders
                        .Where(o => o.Type == type)
                        .Select(o => new OrderDto
                        {
                            Customer = o.Customer,
                            Items = o.OrderItems
                                .Select(oi => new ItemDto
                                {
                                    Name = oi.Item.Name,
                                    Price = oi.Item.Price,
                                    Quantity = oi.Quantity
                                }),
                            TotalPrice = o.OrderItems.Sum(oi => oi.Item.Price * oi.Quantity)
                        })
                        .OrderByDescending(o => o.TotalPrice)
                        .ThenByDescending(o => o.Items.Count()),
                    TotalMade = e.Orders.Sum(o => o.OrderItems.Sum(oi => oi.Item.Price * oi.Quantity))
                })
                .FirstOrDefault();

            string jsonString = JsonConvert.SerializeObject(employee, Newtonsoft.Json.Formatting.Indented);
            return jsonString;
		}

		public static string ExportCategoryStatistics(FastFoodDbContext context, string categoriesString)
		{
            string[] categoriesNames = categoriesString.Split(',');

            var categories = context.Categories
                .Where(c => categoriesNames.Contains(c.Name))
                .Select(c => new CategoryDto
                {
                    Name = c.Name,
                    MostPopularItem = c.Items
                        .Select(i => new MostPopularItemDto
                        {
                            Name = i.Name,
                            TotalMade = i.Price * i.OrderItems.Sum(oi => oi.Quantity),
                            TimesSold = i.OrderItems.Sum(oi => oi.Quantity)
                        })
                        .OrderByDescending(i => i.TotalMade)
                        .First()
                })
                .OrderByDescending(c => c.MostPopularItem.TotalMade)
                .ThenByDescending(c => c.MostPopularItem.TimesSold)
                .ToArray();

            var result = new StringBuilder();
            var xmlNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(typeof(CategoryDto[]), new XmlRootAttribute("Categories"));
            serializer.Serialize(new StringWriter(result), categories, xmlNamespaces);

            return result.ToString().Trim();
		}
	}
}