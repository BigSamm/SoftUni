using Chushka.App.Controllers.Base;
using Chushka.App.Services.Contracts;
using Chushka.App.ViewModels.Orders;
using Chushka.Models;
using SIS.HTTP.Responses;
using System.Collections.Generic;
using System.Globalization;

namespace Chushka.App.Controllers
{
    public class OrdersController : BaseController
    {
        private readonly IOrdersService ordersService;

        private readonly IProductsService productsService;

        private readonly IUsersService usersService;

        public OrdersController(IOrdersService ordersService, IProductsService productsService, IUsersService usersService)
        {
            this.ordersService = ordersService;
            this.productsService = productsService;
            this.usersService = usersService;
        }

        public IHttpResponse All()
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/users/login");

            if (base.User.Role != "Admin")
                return base.Redirect("/");
            
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

        public IHttpResponse Order(int productId)
        {
            Product product = this.productsService.GetById(productId);
            if (product == null)
                return base.BadRequestError("Invalid product id.");

            User user = this.usersService.GetByUsername(base.User.Username);
            if (user == null)
                return base.BadRequestError("Invalid user.");

            this.ordersService.Register(product.Id, user.Id);

            return base.Redirect("/");
        }
    }
}
