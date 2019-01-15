using PandaWebApp.Models;
using PandaWebApp.Services.Contracts;
using PandaWebApp.ViewModels.Users;
using SIS.HTTP.Cookies;
using SIS.HTTP.Responses;
using SIS.MvcFramework;

namespace PandaWebApp.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public IHttpResponse Login()
        {
            if (base.User.IsLoggedIn)
                return base.Redirect("/");

            return base.View();
        }

        [HttpPost]
        public IHttpResponse Login(UserLoginViewModel model)
        {
            User user = this.usersService.GetByUsernameAndPassword(model.Username, model.Password);

            if (user == null)
                return base.BadRequestErrorWithView("Incorrect username or password.");

            var mvcUser = new MvcUserInfo
            {
                Username = user.Username,
                Role = user.Role.ToString(),
            };
            var cookieContent = base.UserCookieService.GetUserCookie(mvcUser);

            var cookie = new HttpCookie(".auth-cakes", cookieContent, 7) { HttpOnly = true };
            base.Response.Cookies.Add(cookie);
            return base.Redirect("/");
        }

        public IHttpResponse Register()
        {
            if (base.User.IsLoggedIn)
                return base.Redirect("/");

            return base.View();
        }

        [HttpPost]
        public IHttpResponse Register(UserRegisterViewModel model)
        {
            if (model.Password != model.ConfirmPassword)
                return base.BadRequestErrorWithView("Passwords do not match");

            this.usersService.Register(model.Username, model.Password, model.Email);

            return base.Redirect("/users/login");
        }

        public IHttpResponse Logout()
        {
            if (!base.User.IsLoggedIn)
                return base.Redirect("/");

            var cookie = base.Request.Cookies.GetCookie(".auth-cakes");
            cookie.Delete();
            base.Response.Cookies.Add(cookie);
            return base.Redirect("/");
        }
    }
}
