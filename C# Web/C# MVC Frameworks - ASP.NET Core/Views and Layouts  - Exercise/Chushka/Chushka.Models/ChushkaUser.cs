using Chushka.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Chushka.Models
{
    public class ChushkaUser : IdentityUser
    {
        public ChushkaUser()
        {
            this.Orders = new HashSet<Order>();
        }
        
        public string FullName { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
