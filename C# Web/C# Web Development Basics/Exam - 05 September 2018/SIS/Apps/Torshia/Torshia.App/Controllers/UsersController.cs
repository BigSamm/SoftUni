using SIS.Framework.ActionResults;
using SIS.Framework.Attributes.Method;
using SIS.Framework.Security;
using System.Collections.Generic;
using Torshia.App.Controllers.Base;
using Torshia.App.Services.Contracts;
using Torshia.App.ViewModels.Users;
using Torshia.Models;

namespace Torshia.App.Controllers
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
                return base.View();

            base.SignIn(new IdentityUser
            {
                Username = model.Username,
                Password = model.Password,
                Roles = new List<string> { user.Role.ToString() }
            });

            return base.RedirectToAction("/");
        }
        
        public IActionResult Register()
        {
            return base.View();
        }

        [HttpPost]
        public IActionResult Register(UserRegisterViewModel model)
        {
            if (model.Password != model.ConfirmPassword)
                return base.View();

            this.usersService.Register(model.Username, model.Password, model.Email);

            return base.RedirectToAction("/Users/Login");
        }
        
        public IActionResult Logout()
        {
            base.SignOut();
            return base.RedirectToAction("/");
        }
    }
}