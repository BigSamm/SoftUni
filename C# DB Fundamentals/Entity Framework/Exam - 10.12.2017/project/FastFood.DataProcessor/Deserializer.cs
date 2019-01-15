namespace FastFood.DataProcessor
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using System.IO;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Newtonsoft.Json;

    using Data;
    using Dto.Import;
    using Models;
    using Models.Enums;

    public static class Deserializer
	{
		private const string FailureMessage = "Invalid data format.";
		private const string SuccessMessage = "Record {0} successfully imported.";

		public static string ImportEmployees(FastFoodDbContext context, string jsonString)
		{
            var result = new StringBuilder();

            EmployeeDto[] employeeDtos = JsonConvert.DeserializeObject<EmployeeDto[]>(jsonString);

            var employees = new List<Employee>();

            foreach (EmployeeDto employeeDto in employeeDtos)
            {
                if (!IsValid(employeeDto))
                {
                    result.AppendLine(FailureMessage);
                    continue;
                }

                Position position = GetPosition(context, employeeDto.Position);

                var employee = new Employee
                {
                    Name = employeeDto.Name,
                    Age = employeeDto.Age,
                    Position = position
                };

                employees.Add(employee);

                result.AppendLine(String.Format(SuccessMessage, employee.Name));
            }

            context.Employees.AddRange(employees);
            context.SaveChanges();

            return result.ToString().Trim();
		}

        private static Position GetPosition(FastFoodDbContext context, string positionName)
        {
            Position position = context.Positions.FirstOrDefault(p => p.Name == positionName);

            if (position == null)
            {
                position = new Position
                {
                    Name = positionName
                };

                context.Positions.Add(position);
                context.SaveChanges();
            }

            return position;
        }

        public static string ImportItems(FastFoodDbContext context, string jsonString)
		{
            var result = new StringBuilder();

            var items = new List<Item>();

            ItemDto[] itemDtos = JsonConvert.DeserializeObject<ItemDto[]>(jsonString);

            foreach (ItemDto itemDto in itemDtos)
            {
                if (!IsValid(itemDto) || items.Any(i => i.Name == itemDto.Name))
                {
                    result.AppendLine(FailureMessage);
                    continue;
                }

                Category category = GetCategory(context, itemDto.Category);

                var item = new Item
                {
                    Name = itemDto.Name,
                    Price = itemDto.Price,
                    Category = category
                };

                items.Add(item);

                result.AppendLine(String.Format(SuccessMessage, item.Name));
            }

            context.AddRange(items);
            context.SaveChanges();

            return result.ToString().Trim();
		}

        private static Category GetCategory(FastFoodDbContext context, string categoryName)
        {
            Category category = context.Categories.FirstOrDefault(c => c.Name == categoryName);

            if (category == null)
            {
                category = new Category
                {
                    Name = categoryName
                };

                context.Categories.Add(category);
                context.SaveChanges();
            }

            return category;
        }

        public static string ImportOrders(FastFoodDbContext context, string xmlString)
		{
            var result = new StringBuilder();
            
            var orderItems = new List<OrderItem>();
            var orders = new List<Order>();

            var serializer = new XmlSerializer(typeof(OrderDto[]), new XmlRootAttribute("Orders"));
            OrderDto[] orderDtos = (OrderDto[])serializer.Deserialize(new StringReader(xmlString));

            foreach (OrderDto orderDto in orderDtos)
            {
                if (!IsValid(orderDto))
                {
                    result.AppendLine(FailureMessage);
                    continue;
                }

                bool isValidItem = true;
                foreach (OrderItemDto orderItemDto in orderDto.OrderItems)
                {
                    if (!IsValid(orderItemDto))
                    {
                        isValidItem = false;
                        break;
                    }
                }

                if (isValidItem == false)
                {
                    result.AppendLine(FailureMessage);
                    continue;
                }

                var employee = context.Employees.FirstOrDefault(e => e.Name == orderDto.Employee);
                if (employee == null)
                {
                    result.AppendLine(FailureMessage);
                    continue;
                }

                bool areValidItems = AreValidItems(context, orderDto.OrderItems);
                if (areValidItems == false)
                {
                    result.AppendLine(FailureMessage);
                    continue;
                }

                DateTime date = DateTime.ParseExact(orderDto.DateTime, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                OrderType orderType = Enum.Parse<OrderType>(orderDto.Type);

                var order = new Order
                {
                    Customer = orderDto.Customer,
                    Employee = employee,
                    DateTime = date,
                    Type = orderType,
                    
                };

                orders.Add(order);

                foreach (OrderItemDto orderItemDto in orderDto.OrderItems)
                {
                    Item item = context.Items.FirstOrDefault(i => i.Name == orderItemDto.Name);

                    var orderItem = new OrderItem
                    {
                        Order = order,
                        Item = item,
                        Quantity = orderItemDto.Quantity
                    };

                    orderItems.Add(orderItem);
                }

                result.AppendLine($"Order for {orderDto.Customer} on {date.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)} added");
            }

            context.Orders.AddRange(orders);
            context.SaveChanges();

            context.OrderItems.AddRange(orderItems);
            context.SaveChanges();

            return result.ToString().Trim();
		}

        private static bool AreValidItems(FastFoodDbContext context, OrderItemDto[] items)
        {
            foreach (OrderItemDto item in items)
            {
                if (!context.Items.Any(i => i.Name == item.Name))
                    return false;                
            }

            return true;
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new ValidationContext(obj);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);
            return isValid;
        }
	}
}