using System.Collections.Generic;

namespace Panda.ViewModels.Users
{
    public class UserIndexViewModel
    {
        public List<PackageIndexViewModel> Pending { get; set; }

        public List<PackageIndexViewModel> Shipped { get; set; }

        public List<PackageIndexViewModel> Delivered { get; set; }
    }
}
