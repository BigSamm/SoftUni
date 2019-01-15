using System.Collections.Generic;
namespace CakesWebApp.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        public Product()
        {
            this.OrderProducts = new HashSet<OrderProduct>();
        }

        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
