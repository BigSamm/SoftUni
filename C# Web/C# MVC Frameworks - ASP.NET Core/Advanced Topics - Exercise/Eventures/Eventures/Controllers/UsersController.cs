using AutoMapper;
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
        private readonly IMapper mapper;

        public UsersController(
            SignInManager<EventuresUser> signInManager,
            UserManager<EventuresUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IMapper mapper)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
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

            EventuresUser user = this.userManager.Users.FirstOrDefault(x => x.UserName == model.Username);
            if (user == null)
                return base.View(model);

            var result = this.signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false).Result;

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
            
            if (model.Password != model.ConfirmPassword)
                return base.View();

            EventuresUser user = this.mapper.Map<EventuresUser>(model);

            IdentityResult result = this.userManager.CreateAsync(user, model.Password).Result;
            
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