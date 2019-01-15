using Chushka.Models.Base;
using System;

namespace Chushka.Models
{
    public class Order : BaseModel<int>
    {
        public Order()
        {
            this.OrderedOn = DateTime.UtcNow;
        }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int ClientId { get; set; }
        public virtual User Client { get; set; }

        public DateTime OrderedOn { get; set; }
    }
}
