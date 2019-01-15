namespace FastFood.DataProcessor.Dto.Export
{
    using System.Collections.Generic;

    public class EmployeeDto
    {
        public string Name { get; set; }

        public IEnumerable<OrderDto> Orders { get; set; }

        public decimal TotalMade { get; set; }
    }
}
