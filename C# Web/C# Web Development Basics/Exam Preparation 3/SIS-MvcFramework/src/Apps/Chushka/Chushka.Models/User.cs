using Chushka.Models.Base;
using Chushka.Models.Enums;
using System.Collections.Generic;

namespace Chushka.Models
{
    public class User : BaseModel<int>
    {
        public User()
        {
            this.Orders = new HashSet<Order>();
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public UserRole Role { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
