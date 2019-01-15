using AutoMapper;
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
        private readonly IMapper mapper;

        public OrdersController(IOrdersService ordersService, UserManager<EventuresUser> userManager, IMapper mapper)
        {
            this.ordersService = ordersService;
            this.userManager = userManager;
            this.mapper = mapper;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult All()
        {
            IEnumerable<Order> dbEvents = this.ordersService.GetAll();
            var eventViewModels = new List<OrderAllViewModel>();

            foreach (Order order in dbEvents)
            {
                eventViewModels.Add(this.mapper.Map<OrderAllViewModel>(order));
            }

            var viewModel = new AllOrdersViewModel { Orders = eventViewModels };

            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Order(string eventId, int tickets)
        {
            EventuresUser currentUser = this.userManager.Users.First(x => x.UserName == this.User.Identity.Name);

            bool succeed = this.ordersService.Create(currentUser.Id, eventId, tickets);
            if (!succeed)
                return base.View("Error");

            return base.RedirectToAction("My", "Events");
        }
    }
}
