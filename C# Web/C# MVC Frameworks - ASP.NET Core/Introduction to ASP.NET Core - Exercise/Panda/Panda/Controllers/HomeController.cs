namespace Panda.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Panda.Models.Enums;
    using Panda.Services.Contracts;
    using Panda.ViewModels.Users;
    using System.Collections.Generic;
    using System.Linq;

    public class HomeController : BaseController
    {
        private readonly IPackagesService packagesService;

        public HomeController(IPackagesService packagesService)
        {
            this.packagesService = packagesService;
        }

        public IActionResult Index()
        {
            if (!base.User.Identity.IsAuthenticated)
                return base.View();

            List<PackageIndexViewModel> pendingPackages =
                this.packagesService.GetAllByStatusAndUsername(PackageStatus.Pending, base.User.Identity.Name)
                .Select(x => new PackageIndexViewModel { Id = x.Id, Name = x.Description }).ToList();
            List<PackageIndexViewModel> shippedPackages =
                this.packagesService.GetAllByStatusAndUsername(PackageStatus.Shipped, base.User.Identity.Name)
                .Select(x => new PackageIndexViewModel { Id = x.Id, Name = x.Description }).ToList();
            List<PackageIndexViewModel> deliveredPackages =
                this.packagesService.GetAllByStatusAndUsername(PackageStatus.Delivered, base.User.Identity.Name)
                .Select(x => new PackageIndexViewModel { Id = x.Id, Name = x.Description }).ToList();

            var viewModel = new UserIndexViewModel()
            {
                Pending = pendingPackages,
                Shipped = shippedPackages,
                Delivered = deliveredPackages,
            };

            return base.View("LoggedInIndex", viewModel);
        }
    }
}
