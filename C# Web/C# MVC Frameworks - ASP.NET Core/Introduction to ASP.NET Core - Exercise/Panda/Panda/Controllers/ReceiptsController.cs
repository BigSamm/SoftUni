using Microsoft.AspNetCore.Mvc;
using Panda.Models;
using Panda.Services.Contracts;
using Panda.ViewModels.Receipts;
using System.Collections.Generic;
using System.Globalization;

namespace Panda.Controllers
{
    public class ReceiptsController : BaseController
    {
        private readonly IReceiptsService receiptsService;

        public ReceiptsController(IReceiptsService receiptsService)
        {
            this.receiptsService = receiptsService;
        }

        public IActionResult Index()
        {
            List<Receipt> receipts = this.receiptsService.GetAllByUsername(base.User.Identity.Name);
            var allReceipts = new List<ReceiptIndexViewModel>();

            foreach (Receipt receipt in receipts)
            {
                allReceipts.Add(new ReceiptIndexViewModel
                {
                    Fee = $"{receipt.Fee:f2}",
                    Id = receipt.Id,
                    IssuedOn = receipt.IssuedOn.ToString("dd/mm/yyyy", CultureInfo.InvariantCulture),
                    Recipient = receipt.Recipient.Username,
                });
            }

            var viewModel = new AllRecipientsIndexViewModel { Receipts = allReceipts };

            return base.View(viewModel);
        }

        public IActionResult Details(int id)
        {
            Receipt receipt = this.receiptsService.GetById(id);

            if (base.User.IsInRole("User") && receipt.Recipient.Username != base.User.Identity.Name)
                return base.Redirect("/");

            if (receipt == null)
                return base.BadRequest("Invalid receipt");

            var viewModel = new ReceiptDetailsViewModel
            {
                Address = receipt.Package.ShippingAddress,
                Description = receipt.Package.Description,
                Fee = $"{receipt.Fee:f2}",
                Id = receipt.Id,
                IssuedOn = receipt.IssuedOn.ToString("dd/mm/yyyy", CultureInfo.InvariantCulture),
                Recipient = receipt.Recipient.Username,
                Weight = receipt.Package.Weight,
            };

            return base.View(viewModel);
        }
    }
}
