using System;
using System.Globalization;

namespace Eventures.ViewModels.Events
{
    public class EventAllViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }
        
        public DateTime Start { get; set; }
        public string StartStr => this.Start.ToString("dd-MMM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);

        public DateTime End { get; set; }
        public string EndStr => this.End.ToString("dd-MMM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
    }
}
