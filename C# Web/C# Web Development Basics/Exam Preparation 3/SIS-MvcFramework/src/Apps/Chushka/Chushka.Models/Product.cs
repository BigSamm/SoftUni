using Chushka.Models.Base;
using Chushka.Models.Enums;
using System.Collections.Generic;

namespace Chushka.Models
{
    public class Product : BaseModel<int>
    {
        public Product()
        {
            this.Orders = new HashSet<Order>();
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public ProductType Type { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
