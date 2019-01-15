using Chushka.Services.Contracts;
using Chushka.ViewModels.Orders;
using Chushka.Models;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Chushka.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersService ordersService;
        private readonly IProductsService productsService;
        private readonly UserManager<ChushkaUser> userManager;

        public OrdersController(IOrdersService ordersService, IProductsService productsService, UserManager<ChushkaUser> userManager)
        {
            this.ordersService = ordersService;
            this.productsService = productsService;
            this.userManager = userManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult All()
        {
            List<Order> orders = this.ordersService.GetAll();

            var orderViewModels = new List<OrderViewModel>();
            int index = 1;

            foreach (Order order in orders)
            {
                orderViewModels.Add(new OrderViewModel
                {
                    CustomerName = order.Client.FullName,
                    Id = order.Id,
                    Index = index++,
                    OrderedOn = order.OrderedOn.ToString("HH:mm dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductName = order.Product.Name,
                });
            }

            var allOrdersViewModels = new AllOrdersViewModel { Orders = orderViewModels };

            return base.View(allOrdersViewModels);
        }

        public IActionResult Order(int productId)
        {
            Product product = this.productsService.GetById(productId);
            ChushkaUser user = this.userManager.Users.FirstOrDefault(x => x.UserName == this.User.Identity.Name);

            this.ordersService.Register(product.Id, user.Id);

            return base.RedirectToAction("Index", "Home");
        }
    }
}
