using MishMash.App.Models.Base;
using MishMash.App.Models.Enums;
using System.Collections.Generic;

namespace MishMash.App.Models
{
    public class Channel : BaseModel<int>
    {
        public Channel()
        {
            this.Tags = new HashSet<ChannelTag>();
            this.Followers = new HashSet<UserChannel>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public ChannelType Type { get; set; }

        public virtual ICollection<ChannelTag> Tags { get; set; }

        public virtual ICollection<UserChannel> Followers { get; set; }
    }
}