using PandaWebApp.Models;
using PandaWebApp.Models.Enums;
using PandaWebApp.Services.Contracts;
using PandaWebApp.ViewModels.Packages;
using SIS.HTTP.Responses;
using SIS.MvcFramework;
using System.Collections.Generic;
using System.Globalization;

namespace PandaWebApp.Controllers
{
    public class PackagesController : BaseController
    {
        private readonly IPackagesService packagesService;

        private readonly IUsersService usersService;

        private readonly IReceiptsService receiptsService;

        public PackagesController(IPackagesService packagesService, IUsersService usersService, IReceiptsService receiptsService)
        {
            this.packagesService = packagesService;
            this.usersService = usersService;
            this.receiptsService = receiptsService;
        }

        public IHttpResponse Details (int id)
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/");

            Package package = this.packagesService.GetById(id);

            if (base.User.Role == "User" && package.Recipient.Username != base.User.Username)
                return base.Redirect("/");

            if (package == null)
                return base.BadRequestError("Invalid package.");

            PackageStatus status = package.Status;
            string estimatedDeliveryDate = null;
            if (status == PackageStatus.Pending)
                estimatedDeliveryDate = "N/A";
            else if (status == PackageStatus.Shipped)
                estimatedDeliveryDate = package.EstimatedDeliveryDate?.ToString("dd/mm/yyyy", CultureInfo.InvariantCulture);
            else
                estimatedDeliveryDate = "Delivered";

            var viewModel = new PackageDetailsViewModel
            {
                Address = package.ShippingAddress,
                Description = package.Description,
                EstimatedDeliveryDate = estimatedDeliveryDate,
                Recipient = package.Recipient.Username,
                Status = package.Status.ToString(),
                Weight = package.Weight,
            };

            return base.View(viewModel);
        }

        public IHttpResponse Create()
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/");

            if (base.User.Role != "Admin")
                return base.Redirect("/");

            List<string> recipients = this.usersService.GetAllUsernames();

            var viewModel = new AllRecipientsViewModel { Recipients = recipients };

            return base.View(viewModel)
;
        }

        [HttpPost]
        public IHttpResponse Create(PackageCreateViewModel model)
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/");

            if (base.User.Role != "Admin")
                return base.Redirect("/");

            User user = this.usersService.GetByUsername(model.Recipient);
            if (user == null)
                return base.BadRequestError("Invalid user.");

            int packageId = this.packagesService.Register(model.Description, model.Weight, model.ShippingAddress, user.Id);

            return base.Redirect("/packages/details?id=" + packageId);
        }

        public IHttpResponse Pending()
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/");

            if (base.User.Role != "Admin")
                return base.Redirect("/");

            List<Package> packages = this.packagesService.GetAllByStatus(PackageStatus.Pending);
            var packagesViewModels = new List<PackageBaseViewModel>();

            int index = 1;
            foreach (Package package in packages)
            {
                packagesViewModels.Add(new PackageBaseViewModel
                {
                    Index = index++,
                    Description = package.Description,
                    Id = package.Id,
                    Recipient = package.Recipient.Username,
                    ShippingAddress = package.ShippingAddress,
                    Weight = package.Weight,
                });
            }

            var viewModel = new AllPackagesViewModel { Packages = packagesViewModels };
 
            return base.View(viewModel);
        }

        public IHttpResponse Shipped()
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/");

            if (base.User.Role != "Admin")
                return base.Redirect("/");

            List<Package> packages = this.packagesService.GetAllByStatus(PackageStatus.Shipped);
            var packagesViewModels = new List<PackageShippedViewModel>();

            int index = 1;
            foreach (Package package in packages)
            {
                packagesViewModels.Add(new PackageShippedViewModel
                {
                    Index = index++,
                    Description = package.Description,
                    Id = package.Id,
                    Recipient = package.Recipient.Username,
                    EstimatedDeliveryDate = package.EstimatedDeliveryDate?.ToString("dd/mm/yyyy", CultureInfo.InvariantCulture),
                    Weight = package.Weight,
                });
            }

            var viewModel = new ShippedPackagesViewModel { Packages = packagesViewModels };

            return base.View(viewModel);
        }

        public IHttpResponse Delivered()
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/");

            if (base.User.Role != "Admin")
                return base.Redirect("/");

            List<Package> packages = this.packagesService.GetAllByStatus(PackageStatus.Delivered);
            packages.AddRange(this.packagesService.GetAllByStatus(PackageStatus.Acquired));

            var packagesViewModels = new List<PackageBaseViewModel>();

            int index = 1;
            foreach (Package package in packages)
            {
                packagesViewModels.Add(new PackageBaseViewModel
                {
                    Index = index++,
                    Description = package.Description,
                    Id = package.Id,
                    Recipient = package.Recipient.Username,
                    ShippingAddress = package.ShippingAddress,
                    Weight = package.Weight,
                });
            }

            var viewModel = new AllPackagesViewModel { Packages = packagesViewModels };

            return base.View(viewModel);
        }

        public IHttpResponse Deliver(int id)
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/");

            if (base.User.Role != "Admin")
                return base.Redirect("/");

            Package package = this.packagesService.GetById(id);

            if (package == null || package.Status != PackageStatus.Shipped)
                return base.BadRequestError("Invalid package");

            this.packagesService.Deliver(package);

            return base.Redirect("/packages/shipped");
        }

        public IHttpResponse Ship(int id)
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/");

            if (base.User.Role != "Admin")
                return base.Redirect("/");

            Package package = this.packagesService.GetById(id);

            if (package == null || package.Status != PackageStatus.Pending)
                return base.BadRequestError("Invalid package");
            
            this.packagesService.Ship(package);

            return base.Redirect("/packages/pending");
        }

        public IHttpResponse Acquire(int id)
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/");

            Package package = this.packagesService.GetById(id);
            User user = this.usersService.GetByUsername(base.User.Username);

            if (package == null
                || user == null
                || package.Status != PackageStatus.Delivered
                || package.RecipientId != user.Id)
            {
                return BadRequestError("Invalid package or user.");
            }

            this.packagesService.Acquire(package);
            this.receiptsService.Register(package, user);

            return base.Redirect("/receipts/index");
        }
    }
}
