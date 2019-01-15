using PandaWebApp.Models;
using PandaWebApp.Services.Contracts;
using PandaWebApp.ViewModels.Receipts;
using SIS.HTTP.Responses;
using System.Collections.Generic;
using System.Globalization;

namespace PandaWebApp.Controllers
{
    public class ReceiptsController : BaseController
    {
        private readonly IReceiptsService receiptsService;

        public ReceiptsController(IReceiptsService receiptsService)
        {
            this.receiptsService = receiptsService;
        }

        public IHttpResponse Index()
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/");

            List<Receipt> receipts = this.receiptsService.GetAllByUsername(base.User.Username);
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

        public IHttpResponse Details(int id)
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/");

            Receipt receipt = this.receiptsService.GetById(id);

            if (base.User.Role == "User" && receipt.Recipient.Username != base.User.Username)
                return base.Redirect("/");

            if (receipt == null)
                return base.BadRequestError("Invalid receipt");

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
