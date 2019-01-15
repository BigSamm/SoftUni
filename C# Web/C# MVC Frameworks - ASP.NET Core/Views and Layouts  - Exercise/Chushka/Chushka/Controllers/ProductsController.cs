using Chushka.Services.Contracts;
using Chushka.ViewModels.Products;
using Chushka.Models;
using Chushka.Models.Enums;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Chushka.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        [Authorize]
        public IActionResult Details(int id)
        {
            Product product = this.productsService.GetById(id);
            
            var viewModel = new ProductBaseViewModel
            {
                Id = product.Id,
                Description = product.Description,
                Name = product.Name,
                Price = product.Price,
                Type = product.Type.ToString(),
            };

            return base.View(viewModel);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return base.View();
        }

        [HttpPost]
        public IActionResult Create(ProductBaseViewModel model)
        {
            bool isValidType = Enum.TryParse(model.Type, out ProductType type);

            int productId = this.productsService.Register(model.Name, model.Price, model.Description, type);

            return base.RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            Product product = this.productsService.GetById(id);
            
            var viewModel = new ProductBaseViewModel
            {
                Id = id,
                Description = product.Description,
                Name = product.Name,
                Price = product.Price,
                Type = product.Type.ToString(),
            };

            return base.View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(ProductBaseViewModel model)
        {
            Product product = this.productsService.GetById(model.Id);

            ProductType type = Enum.Parse<ProductType>(model.Type);

            this.productsService.Update(product, model.Name, model.Price, model.Description, type);

            return base.RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            Product product = this.productsService.GetById(id);
            
            var viewModel = new ProductBaseViewModel
            {
                Id = id,
                Description = product.Description,
                Name = product.Name,
                Price = product.Price,
                Type = product.Type.ToString(),
            };

            return base.View(viewModel);
        }

        [HttpPost]
        public IActionResult Delete(ProductDeleteViewModel model)
        {
            Product product = this.productsService.GetById(model.Id);
            
            this.productsService.Delete(product);

            return base.RedirectToAction("Index", "Home");
        }
    }
}
