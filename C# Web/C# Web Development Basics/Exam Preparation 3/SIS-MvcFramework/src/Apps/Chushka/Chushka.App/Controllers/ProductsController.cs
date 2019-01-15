using Chushka.App.Controllers.Base;
using Chushka.App.Services.Contracts;
using Chushka.App.ViewModels.Products;
using Chushka.Models;
using Chushka.Models.Enums;
using SIS.HTTP.Responses;
using SIS.MvcFramework;
using System;

namespace Chushka.App.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly IProductsService productsService;
        
        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        public IHttpResponse Details(int id)
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/users/login");

            Product product = this.productsService.GetById(id);

            if (product == null)
                return base.BadRequestError("Invalid product id.");

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

        public IHttpResponse Create()
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/users/login");

            if (base.User.Role != "Admin")
                return base.Redirect("/");
            
            return base.View();
        }

        [HttpPost]
        public IHttpResponse Create(ProductBaseViewModel model)
        {
            bool isValidType = Enum.TryParse(model.Type, out ProductType type);
            if (!isValidType)
                return base.BadRequestErrorWithView("Invalid product type.");

            int productId = this.productsService.Register(model.Name, model.Price, model.Description, type);

            return base.Redirect("/products/details?Id=" + productId);
        }

        public IHttpResponse Edit(int id)
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/users/login");

            if (base.User.Role != "Admin")
                return base.Redirect("/");
            
            Product product = this.productsService.GetById(id);

            if (product == null)
                return base.BadRequestError("Invalid product id.");

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
        public IHttpResponse Edit(ProductBaseViewModel model)
        {
            Product product = this.productsService.GetById(model.Id);

            if (product == null)
                return base.BadRequestError("Invalid product id.");

            bool isValidType = Enum.TryParse(model.Type, out ProductType type);
            if (!isValidType)
                return base.BadRequestErrorWithView("Invalid product type.");

            this.productsService.Update(product, model.Name, model.Price, model.Description, type);

            return base.Redirect("/products/details?Id=" + product.Id);
        }

        public IHttpResponse Delete(int id)
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/users/login");

            if (base.User.Role != "Admin")
                return base.Redirect("/");

            Product product = this.productsService.GetById(id);

            if (product == null)
                return base.BadRequestError("Invalid product id.");

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
        public IHttpResponse Delete(ProductDeleteViewModel model)
        {
            Product product = this.productsService.GetById(model.Id);

            if (product == null)
                return base.BadRequestError("Invalid product id.");

            this.productsService.Delete(product);

            return base.Redirect("/");
        }
    }
}
