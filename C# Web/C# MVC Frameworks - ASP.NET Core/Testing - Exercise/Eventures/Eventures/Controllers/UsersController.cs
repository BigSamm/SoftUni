using Eventures.Models;
using Eventures.Services.Contracts;
using Eventures.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Chushka.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;
        private readonly SignInManager<EventuresUser> signInManager;

        public UsersController(IUsersService usersService, SignInManager<EventuresUser> signInManager)
        {
            this.usersService = usersService;
            this.signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLoginViewModel model)
        {
            if (!base.ModelState.IsValid)
                return base.View(model);

            var result = this.usersService.Login(model);

            if (!result.Succeeded)
                return base.View(model);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserRegisterViewModel model)
        {
            if (!base.ModelState.IsValid)
                return base.View(model);

            IdentityResult result = this.usersService.Register(model);

            if (!result.Succeeded)
                return base.View(model);

            return base.RedirectToAction("Login", "Users");
        }

        public IActionResult Logout()
        {
            this.signInManager.SignOutAsync();
            return base.RedirectToAction("Index", "Home");
        }

        public IActionResult Administration()
        {
            IEnumerable<UserViewModel> admins = this.usersService.GetAllByRole("Admin");
            IEnumerable<UserViewModel> users = this.usersService.GetAllByRole("User");
            
            var viewModel = new UsersAdministrationViewModel
            {
                Admins = admins,
                Users = users,
            };
            
            return base.View(viewModel);
        }

        public IActionResult Demote(string id)
        {
            this.usersService.Demote(id);
            return base.RedirectToAction("Administration", "Users");
        }

        public IActionResult Promote(string id)
        {
            this.usersService.Promote(id);
            return base.RedirectToAction("Administration", "Users");
        }
    }
}