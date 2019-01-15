using System.Collections.Generic;

namespace Eventures.ViewModels.Events
{
    public class AllEventsViewModel
    {
        public IEnumerable<EventInfoViewModel> Events { get; set; }
    }
}
