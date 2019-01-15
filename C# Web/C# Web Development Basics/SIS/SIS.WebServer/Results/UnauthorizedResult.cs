namespace SIS.WebServer.Results
{
    using System.Net;
    using System.Text;

    using HTTP.Headers;
    using HTTP.Responses;

    public class UnauthorizedResult : HttpResponse
    {
        private const string DefaultErrorHeading = "<h1>You have no permission to access this functionality.</h1>";

        public UnauthorizedResult()
            : base(HttpStatusCode.Unauthorized)
        {
            base.Headers.Add(new HttpHeader(HttpHeader.ContentType, "text/html"));
            base.Content = Encoding.UTF8.GetBytes(DefaultErrorHeading);
        }
    }
}