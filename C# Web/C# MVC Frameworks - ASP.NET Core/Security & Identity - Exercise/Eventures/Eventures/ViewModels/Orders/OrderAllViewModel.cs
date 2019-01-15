using System;
using System.Globalization;

namespace Eventures.ViewModels.Orders
{
    public class OrderAllViewModel
    {
        public string Event { get; set; }

        public string Customer { get; set; }

        public DateTime OrderedOn { get; set; }
        public string OrderedOnStr => this.OrderedOn.ToString("dd-MMM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
    }
}
