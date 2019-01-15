namespace CakesWebApp.Controllers
{
    using System;
    using System.Linq;
    using System.Net;

    using Models;
    using Services;
    using Services.Contracts;
    using SIS.HTTP.Cookies;
    using SIS.HTTP.Requests.Contracts;
    using SIS.HTTP.Responses.Contracts;
    using SIS.WebServer.Results;

    public class AccountController : BaseController
    {
        private IHashService hashService;

        public AccountController()
        {
            this.hashService = new HashService();
        }

        public IHttpResponse Register(IHttpRequest request)
        {
            return base.View("Register");
        }

        public IHttpResponse DoRegister(IHttpRequest request)
        {
            string username = request.FormData["username"].ToString().Trim();
            string password = request.FormData["password"].ToString();
            string confirmPassword = request.FormData["confirmPassword"].ToString();

            if (String.IsNullOrWhiteSpace(username))
                return base.BadRequestError("Please provide valid username!");

            if (base.Db.Users.Any(x => x.Username == username))
                return base.BadRequestError("Username already exists!");

            if (String.IsNullOrEmpty(password))
                return base.BadRequestError("Please provide valid password!");

            if (password != confirmPassword)
                return base.BadRequestError("Passwords do not match!");

            string hashedPassword = this.hashService.Hash(password);

            var user = new User
            {
                Name = username,
                Username = username,
                Password = hashedPassword
            };

            base.Db.Users.Add(user);

            try
            {
                base.Db.SaveChanges();
            }
            catch (Exception ex)
            {
                return base.ServerError(ex.Message);
            }

            return new RedirectResult("/");
        }

        public IHttpResponse Login(IHttpRequest request)
        {
            return base.View("Login");
        }

        public IHttpResponse DoLogin(IHttpRequest request)
        {
            string username = request.FormData["username"].ToString().Trim();
            string password = request.FormData["password"].ToString();

            string hashedPassword = this.hashService.Hash(password);

            User user = base.Db.Users.FirstOrDefault(x => x.Username == username && x.Password == hashedPassword);

            if (user == null)
                return this.BadRequestError("Invalid username or password!");

            string cookieContent = base.UserCookieService.GetUserCookie(username);

            var response = new RedirectResult("/");
            response.Cookies.Add(new HttpCookie(".auth-cakes", cookieContent, 7));
            return response;
        }
    }
}