using Chushka.Models;
using Chushka.Services.Contracts;
using Chushka.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Chushka.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsService productsService;

        public HomeController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        public IActionResult Index()
        {
            if (!base.User.Identity.IsAuthenticated)
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

            return base.View("LoggedInIndex", allProductsViewModel);
        }
    }
}
