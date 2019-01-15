namespace SIS.WebServer.Results
{
    using System.Net;

    using HTTP.Headers;
    using HTTP.Responses;

    public class InlineResourceResult : HttpResponse
    {
        public InlineResourceResult(byte[] content, HttpStatusCode statusCode)
            : base(statusCode)
        {
            base.Headers.Add(new HttpHeader(HttpHeader.ContentLength, content.Length.ToString()));
            base.Headers.Add(new HttpHeader(HttpHeader.ContentDisposition, "inline"));
            base.Content = content;
        }
    }
}
