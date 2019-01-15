namespace CakesWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        public Order()
        {
            this.DateOfCreation = DateTime.UtcNow;
            this.OrderProducts = new HashSet<OrderProduct>();
        }

        [Key]
        public int OrderId { get; set; }

        public DateTime DateOfCreation { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
