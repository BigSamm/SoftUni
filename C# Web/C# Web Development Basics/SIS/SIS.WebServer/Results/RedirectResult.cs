namespace SIS.WebServer.Results
{
    using System.Net;

    using HTTP.Responses;
    using HTTP.Headers;

    public class RedirectResult : HttpResponse
    {
        public RedirectResult(string location)
            :base(HttpStatusCode.Redirect)
        {
            base.Headers.Add(new HttpHeader("Location", location));
        }
    }
}
