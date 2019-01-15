using MishMash.App.ViewModels.Users;
using MishMash.App.Models;
using MishMash.App.Models.Enums;
using SIS.HTTP.Cookies;
using SIS.HTTP.Responses;
using SIS.MvcFramework;
using SIS.MvcFramework.Services;
using System;
using System.Linq;

namespace MishMash.App.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IHashService hashService;

        public UsersController(IHashService hashService)
        {
            this.hashService = hashService;
        }

        public IHttpResponse Login()
        {
            return base.View();
        }

        [HttpPost]
        public IHttpResponse Login(LoginViewModel model)
        {
            string hashedPassword = this.hashService.Hash(model.Password);
            User user = base.DbContext.Users
                .FirstOrDefault(x => x.Username == model.Username.Trim() && x.Password == hashedPassword);

            if (user == null)
                return this.BadRequestErrorWithView("Invalid username or password");
            
            var mvcUser = new MvcUserInfo { Username = user.Username, Role = user.Role.ToString(), Info = user.Email };
            var cookieContent = this.UserCookieService.GetUserCookie(mvcUser);

            var cookie = new HttpCookie(".auth-cakes", cookieContent, 7) { HttpOnly = true };
            this.Response.Cookies.Add(cookie);

            return this.Redirect("/");
        }

        public IHttpResponse Register()
        {
            return base.View();
        }

        [HttpPost]
        public IHttpResponse Register(RegisterViewModel model)
        {
            if (base.DbContext.Users.Any(x => x.Username == model.Username))
                return base.BadRequestErrorWithView("Username already in use.");

            if (base.DbContext.Users.Any(x => x.Email == model.Email))
                return base.BadRequestErrorWithView("Email already in use.");

            if (model.Password != model.ConfirmPassword)
                return base.BadRequestErrorWithView("Passwords do not match.");

            string hashedPassword = this.hashService.Hash(model.Password);

            var user = new User
            {
                Username = model.Username,
                Password = hashedPassword,
                Email = model.Email,
                Role = UserRole.User
            };

            base.DbContext.Users.Add(user);

            try
            {
                base.DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return base.BadRequestErrorWithView(ex.Message);
            }

            return this.Redirect("/Users/Login");
        }

        [Authorize]
        public IHttpResponse Logout()
        {
            if (!base.Request.Cookies.ContainsCookie(".auth-cakes"))
                return base.Redirect("/");

            var cookie = this.Request.Cookies.GetCookie(".auth-cakes");
            cookie.Delete();
            this.Response.Cookies.Add(cookie);
            return this.Redirect("/");
        }
    }
}