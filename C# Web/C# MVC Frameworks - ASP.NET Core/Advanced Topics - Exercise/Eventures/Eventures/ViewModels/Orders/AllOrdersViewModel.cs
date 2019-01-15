using System.Collections.Generic;

namespace Eventures.ViewModels.Orders
{
    public class AllOrdersViewModel
    {
        public IEnumerable<OrderAllViewModel> Orders { get; set; }
    }
}
