using System.Collections.Generic;
using Torshia.Models.Base;
using Torshia.Models.Enums;

namespace Torshia.Models
{
    public class User : BaseModel<int>
    {
        public User()
        {
            this.Reports = new HashSet<Report>();
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public UserRole Role { get; set; }

        public virtual ICollection<Report> Reports { get; set; }
    }
}