using Eventures.Models;
using Eventures.Services.Contracts;
using Eventures.ViewModels.Orders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Eventures.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersService ordersService;
        private readonly UserManager<EventuresUser> userManager;

        public OrdersController(IOrdersService ordersService, UserManager<EventuresUser> userManager)
        {
            this.ordersService = ordersService;
            this.userManager = userManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult All()
        {
            IEnumerable<Order> dbEvents = this.ordersService.GetAll();
            var eventViewModels = new List<OrderAllViewModel>();

            foreach (Order order in dbEvents)
            {
                eventViewModels.Add(new OrderAllViewModel
                {
                    Customer = order.Customer.UserName,
                    Event = order.Event.Name,
                    OrderedOn = order.OrderedOn,
                });
            }

            var viewModel = new AllOrdersViewModel { Orders = eventViewModels };

            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Order(string eventId, int tickets)
        {
            EventuresUser currentUser = this.userManager.Users.First(x => x.UserName == this.User.Identity.Name);
            this.ordersService.Create(currentUser.Id, eventId, tickets);
            return base.RedirectToAction("My", "Events");
        }
    }
}
