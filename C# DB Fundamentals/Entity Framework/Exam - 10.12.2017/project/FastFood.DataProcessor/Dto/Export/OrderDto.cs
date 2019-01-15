namespace FastFood.DataProcessor.Dto.Export
{
    using System.Collections.Generic;
    using System.Linq;

    public class OrderDto
    {
        public string Customer { get; set; }

        public IEnumerable<ItemDto> Items { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
