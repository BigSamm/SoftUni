namespace ProductShop.App.Dtos
{
    public class CategoryProductsDto
    {
        public string Name { get; set; }

        public int ProductsCount { get; set; }

        public decimal AveragePrice { get; set; }

        public decimal TotalRevenue { get; set; }
    }
}
