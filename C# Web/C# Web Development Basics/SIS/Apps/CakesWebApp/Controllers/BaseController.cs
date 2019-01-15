namespace CakesWebApp.Controllers
{
    using System.IO;
    using System.Net;

    using Data;
    using Services;
    using Services.Contracts;
    using SIS.HTTP.Requests.Contracts;
    using SIS.HTTP.Responses.Contracts;
    using SIS.WebServer.Results;

    public abstract class BaseController
    {
        protected BaseController()
        {
            this.Db = new CakesDbContext();
            this.UserCookieService = new UserCookieService();
        }

        protected CakesDbContext Db { get; }

        protected IUserCookieService UserCookieService { get; }

        protected string GetUser(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth-cakes"))
                return null;
            
            string cookieContent = request.Cookies.GetCookie(".auth-cakes").Value;

            string username = this.UserCookieService.GetUserData(cookieContent);
            return username;
        }

        protected IHttpResponse View(string viewName)
        {
            string content = File.ReadAllText("Views/" + viewName + ".html");
            return new HtmlResult(content, HttpStatusCode.OK);
        }

        protected IHttpResponse BadRequestError(string errorMsg)
        {
            return new HtmlResult($"<h1>{errorMsg}</h1>", HttpStatusCode.BadRequest);
        }

        protected IHttpResponse ServerError(string errorMsg)
        {
            return new HtmlResult($"<h1>{errorMsg}</h1>", HttpStatusCode.InternalServerError);
        }
    }
}
