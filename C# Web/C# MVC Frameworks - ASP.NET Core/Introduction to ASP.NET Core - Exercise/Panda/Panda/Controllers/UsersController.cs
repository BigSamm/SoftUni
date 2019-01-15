using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Panda.Models;
using Panda.Services.Contracts;
using Panda.ViewModels.Users;
using System.Security.Claims;

namespace Panda.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public IActionResult Login()
        {
            return base.View();
        }

        [HttpPost]
        public IActionResult Login(UserLoginViewModel model)
        {
            User user = this.usersService.GetByUsernameAndPassword(model.Username, model.Password);

            if (user == null)
                return base.BadRequest("Incorrect Username or password.");

            return base.SignIn(new ClaimsPrincipal(), null);            
        }

        public IActionResult Register()
        {
            return base.View();
        }

        [HttpPost]
        public IActionResult Register(UserRegisterViewModel model)
        {
            if (model.Password != model.ConfirmPassword)
                return base.BadRequest("Passwords do not match");

            this.usersService.Register(model.Username, model.Password, model.Email);

            return base.Redirect("/users/login");
        }

        public IActionResult Logout()
        {
            return base.SignOut();
        }
    }
}
