using MishMash.App.ViewModels.Channels;
using System.Collections.Generic;

namespace MishMash.App.ViewModels.Home
{
    public class LoggedInIndexViewModel
    {
        public IEnumerable<BaseChannelViewModel> YourChannels { get; set; }

        public IEnumerable<BaseChannelViewModel> SuggestedChannels { get; set; }

        public IEnumerable<BaseChannelViewModel> SeeOtherChannels { get; set; }
    }
}