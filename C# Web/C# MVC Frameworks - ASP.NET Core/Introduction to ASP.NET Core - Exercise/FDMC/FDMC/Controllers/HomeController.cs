using FDMC.ViewModels.Cats;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FDMC.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            var allCats = new List<CatIndexViewModel>();
            foreach (var cat in base.DbContext.Cats)
            {
                allCats.Add(new CatIndexViewModel
                {
                    Id = cat.Id,
                    Name = cat.Name,
                });
            }

            var viewModel = new AllCatsIndexViewModel { Cats = allCats };

            return View(viewModel);
        }
    }
}
