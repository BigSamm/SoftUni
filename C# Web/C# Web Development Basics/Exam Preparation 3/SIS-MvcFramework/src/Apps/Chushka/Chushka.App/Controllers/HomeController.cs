using Chushka.App.Controllers.Base;
using Chushka.App.Services.Contracts;
using Chushka.App.ViewModels.Products;
using Chushka.Models;
using SIS.HTTP.Responses;
using System.Collections.Generic;

namespace Chushka.App.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IProductsService productsService;

        public HomeController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        public IHttpResponse Index()
        {
            if (!base.User.IsLoggedIn)
                return base.View();

            List<Product> products = this.productsService.GetAll();
            var productViewModels = new List<ProductIndexViewModel>();

            foreach (Product product in products)
            {
                string description = product.Description.Length > 50
                    ? product.Description.Substring(0, 50) + "..."
                    : product.Description;

                productViewModels.Add(new ProductIndexViewModel
                {
                    Description = description,
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                });
            }

            var allProductsViewModel = new AllProductsIndexViewModel { Products = productViewModels };

            return base.View("Home/LoggedInIndex", allProductsViewModel);
        }
    }
}
