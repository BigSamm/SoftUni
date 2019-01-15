using MishMash.App.Models.Base;
using MishMash.App.Models.Enums;
using System.Collections.Generic;

namespace MishMash.App.Models
{
    public class User : BaseModel<int>
    {
        public User()
        {
            this.FollowedChannels = new HashSet<UserChannel>();
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public UserRole Role { get; set; }

        public virtual ICollection<UserChannel> FollowedChannels { get; set; }        
    }
}