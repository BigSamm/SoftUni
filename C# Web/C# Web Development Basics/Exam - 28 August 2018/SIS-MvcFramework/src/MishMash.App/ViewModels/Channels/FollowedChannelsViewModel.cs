using System.Collections.Generic;

namespace MishMash.App.ViewModels.Channels
{
    public class FollowedChannelsViewModel
    {
        public IEnumerable<BaseChannelViewModel> FollowedChannels { get; set; }
    }
}