using Chushka.Models;
using Chushka.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Chushka.Controllers
{
    public class UsersController : Controller
    {
        private readonly SignInManager<ChushkaUser> signInManager;
        private readonly UserManager<ChushkaUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UsersController(
            SignInManager<ChushkaUser> signInManager, 
            UserManager<ChushkaUser> userManager, 
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
            ChushkaUser user = this.userManager.Users.FirstOrDefault(x => x.UserName == model.Username);
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
            var user = new ChushkaUser
            {
                UserName = model.Username,
                FullName = model.FullName,
                Email = model.Email,
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