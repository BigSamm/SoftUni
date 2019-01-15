using FDMC.Models;
using FDMC.ViewModels.Cats;
using Microsoft.AspNetCore.Mvc;

namespace FDMC.Controllers
{
    public class CatsController : BaseController
    {
        public IActionResult Create()
        {
            return base.View();
        }

        [HttpPost]
        public IActionResult Create(CatInfoViewModel model)
        {
            var cat = new Cat
            {
                Age = model.Age,
                Breed = model.Breed,
                ImageUrl = model.ImageUrl,
                Name = model.Name,
            };

            base.DbContext.Cats.Add(cat);
            base.DbContext.SaveChanges();

            return base.Redirect("/cats/info?id=" + cat.Id);
        }

        public IActionResult Info(int id)
        {
            var cat = base.DbContext.Cats.Find(id);

            var viewModel = new CatInfoViewModel
            {
                Age = cat.Age,
                Breed = cat.Breed,
                ImageUrl = cat.ImageUrl,
                Name = cat.Name,
            };

            return base.View(viewModel);
        }
    }
}
