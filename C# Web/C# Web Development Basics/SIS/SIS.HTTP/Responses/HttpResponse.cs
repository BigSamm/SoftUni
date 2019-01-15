namespace SIS.HTTP.Responses
{
    using System.Linq;
    using System.Net;
    using System.Text;

    using Common;
    using Contracts;
    using Cookies;
    using Cookies.Contracts;
    using Exceptions;
    using Extensions;
    using Headers;
    using Headers.Contracts;

    public class HttpResponse : IHttpResponse
    {
        public HttpResponse()
        { }

        public HttpResponse(HttpStatusCode statusCode)
        {
            this.Headers = new HttpHeaderCollection();
            this.Cookies = new HttpCookieCollection();
            this.Content = new byte[0];
            this.StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; }

        public IHttpHeaderCollection Headers { get; private set; }

        public IHttpCookieCollection Cookies { get; }

        public byte[] Content { get; set; }

        public void AddHeader(HttpHeader header)
        {
            this.Headers.Add(header);
        }

        public void AddCookie(HttpCookie cookie)
        {
            if (cookie == null)
                throw new BadRequestException();

            this.Cookies.Add(cookie);
        }

        public byte[] GetBytes()
        {
            byte[] result = Encoding.UTF8.GetBytes(this.ToString()).Concat(this.Content).ToArray();
            return result;
        }

        public override string ToString() 
        {
            var result = new StringBuilder();

            result.AppendLine($"{GlobalConstants.HttpOneProtocolFragment} {this.StatusCode.GetResponseLine()}")
                .AppendLine(this.Headers.ToString());

            if (this.Cookies.HasCookies())
            {
                result.AppendLine($"Set-Cookie: {this.Cookies}");
            }

            result.AppendLine();

            return result.ToString();
        }
    }
}
