using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Panda.Models;
using Panda.Models.Enums;
using Panda.Services.Contracts;
using Panda.ViewModels.Packages;
using System.Collections.Generic;
using System.Globalization;

namespace Panda.Controllers
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

        public IActionResult Details (int id)
        {
            Package package = this.packagesService.GetById(id);

            if (base.User.IsInRole("User") && package.Recipient.Username != base.User.Identity.Name)
                return base.Redirect("/");

            if (package == null)
                return base.BadRequest("Invalid package.");

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

        public IActionResult Create()
        {
            List<string> recipients = this.usersService.GetAllUsernames();

            var viewModel = new AllRecipientsViewModel { Recipients = recipients };

            return base.View(viewModel)
;
        }

        [HttpPost]
        public IActionResult Create(PackageCreateViewModel model)
        {
            User user = this.usersService.GetByUsername(model.Recipient);
            if (user == null)
                return base.BadRequest("Invalid user.");

            int packageId = this.packagesService.Register(model.Description, model.Weight, model.ShippingAddress, user.Id);

            return base.Redirect("/packages/details?id=" + packageId);
        }

        public IActionResult Pending()
        {
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

        public IActionResult Shipped()
        {
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

        public IActionResult Delivered()
        {
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

        public IActionResult Deliver(int id)
        {
            Package package = this.packagesService.GetById(id);

            if (package == null || package.Status != PackageStatus.Shipped)
                return base.BadRequest("Invalid package");

            this.packagesService.Deliver(package);

            return base.Redirect("/packages/shipped");
        }

        public IActionResult Ship(int id)
        {
            Package package = this.packagesService.GetById(id);

            if (package == null || package.Status != PackageStatus.Pending)
                return base.BadRequest("Invalid package");
            
            this.packagesService.Ship(package);

            return base.Redirect("/packages/pending");
        }

        public IActionResult Acquire(int id)
        {
            Package package = this.packagesService.GetById(id);
            User user = this.usersService.GetByUsername(base.User.Identity.Name);

            if (package == null
                || user == null
                || package.Status != PackageStatus.Delivered
                || package.RecipientId != user.Id)
            {
                return BadRequest("Invalid package or user.");
            }

            this.packagesService.Acquire(package);
            this.receiptsService.Register(package, user);

            return base.Redirect("/receipts/index");
        }
    }
}
