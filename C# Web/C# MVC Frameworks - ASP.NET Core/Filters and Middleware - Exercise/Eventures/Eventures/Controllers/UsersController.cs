using Eventures.Models;
using Eventures.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Chushka.Controllers
{
    public class UsersController : Controller
    {
        private readonly SignInManager<EventuresUser> signInManager;
        private readonly UserManager<EventuresUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UsersController(
            SignInManager<EventuresUser> signInManager,
            UserManager<EventuresUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLoginViewModel model)
        {
            EventuresUser user = this.userManager.Users.FirstOrDefault(x => x.UserName == model.Username);
            var result = this.signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false).Result;

            if (!result.Succeeded)
                return base.View();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserRegisterViewModel model)
        {
            if (model.Password != model.ConfirmPassword)
                return base.View();

            var user = new EventuresUser
            {
                UserName = model.Username,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                UCN = model.UCN,
            };

            IdentityResult result = this.userManager.CreateAsync(user, model.Password).Result;

            if (this.userManager.Users.Count() == 1)
            {
                IdentityResult roleResult = this.userManager.AddToRoleAsync(user, "Admin").Result;

                if (roleResult.Errors.Any())
                    return base.View();
            }

            if (result.Succeeded)
                return base.RedirectToAction("Login", "Users");

            return base.View();
        }

        public IActionResult Logout()
        {
            this.signInManager.SignOutAsync();

            return base.RedirectToAction("Index", "Home");
        }
    }
}