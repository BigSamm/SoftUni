using Eventures.Services.Contracts;
using Eventures.ViewModels.Orders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Eventures.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersService ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult All()
        {
            IEnumerable<OrderAllViewModel> orders = this.ordersService.GetAll();
            var viewModel = new AllOrdersViewModel { Orders = orders };
            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Order(string eventId, int tickets)
        {
            if (String.IsNullOrEmpty(eventId) || tickets == 0)
                return base.View();
            
            bool succeed = this.ordersService.Create(eventId, tickets, this.User.Identity.Name);
            if (!succeed)
                return base.View("Error");

            return base.RedirectToAction("My", "Events");
        }
    }
}
