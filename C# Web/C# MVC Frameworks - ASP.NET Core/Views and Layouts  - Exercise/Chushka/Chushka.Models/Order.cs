using System;

namespace Chushka.Models
{
    public class Order
    {
        public Order()
        {
            this.OrderedOn = DateTime.UtcNow;
        }

        public int Id { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public string ClientId { get; set; }
        public virtual ChushkaUser Client { get; set; }

        public DateTime OrderedOn { get; set; }
    }
}
