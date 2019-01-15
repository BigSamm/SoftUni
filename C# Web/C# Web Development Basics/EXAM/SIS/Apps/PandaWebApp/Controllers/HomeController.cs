namespace PandaWebApp.Controllers
{
    using PandaWebApp.Models.Enums;
    using PandaWebApp.Services.Contracts;
    using PandaWebApp.ViewModels.Users;
    using SIS.HTTP.Responses;
    using System.Collections.Generic;
    using System.Linq;

    public class HomeController : BaseController
    {
        private readonly IPackagesService packagesService;

        public HomeController(IPackagesService packagesService)
        {
            this.packagesService = packagesService;
        }

        public IHttpResponse Index()
        {
            if (!base.User.IsLoggedIn)
                return this.View();
            
            List<PackageIndexViewModel> pendingPackages =
                this.packagesService.GetAllByStatusAndUsername(PackageStatus.Pending, base.User.Username)
                .Select(x => new PackageIndexViewModel { Id = x.Id, Name = x.Description }).ToList();
            List<PackageIndexViewModel> shippedPackages =
                this.packagesService.GetAllByStatusAndUsername(PackageStatus.Shipped, base.User.Username)
                .Select(x => new PackageIndexViewModel { Id = x.Id, Name = x.Description }).ToList();
            List<PackageIndexViewModel> deliveredPackages =
                this.packagesService.GetAllByStatusAndUsername(PackageStatus.Delivered, base.User.Username)
                .Select(x => new PackageIndexViewModel { Id = x.Id, Name = x.Description }).ToList();

            var viewModel = new UserIndexViewModel()
            {
                Pending = pendingPackages,
                Shipped = shippedPackages,
                Delivered = deliveredPackages,
            };

            return base.View("Home/LoggedInIndex", viewModel);
        }
    }
}
