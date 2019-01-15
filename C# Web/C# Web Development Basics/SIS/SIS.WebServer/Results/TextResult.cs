namespace SIS.WebServer.Results
{
    using System.Net;
    using System.Text;

    using HTTP.Headers;
    using HTTP.Responses;

    public class TextResult : HttpResponse
    {
        public TextResult(string content, HttpStatusCode responseStatusCode)
            :base(responseStatusCode)
        {
            base.Headers.Add(new HttpHeader("Content-Type", "text/plain; charset=utf-8"));
            base.Content = Encoding.UTF8.GetBytes(content);
        }
    }
}
