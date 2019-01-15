namespace SIS.HTTP.Responses.Contracts
{
    using System.Net;

    using Cookies;
    using Headers;
    using Headers.Contracts;
    using Cookies.Contracts;

    public interface IHttpResponse
    {
        HttpStatusCode StatusCode { get; }

        IHttpHeaderCollection Headers { get; }

        IHttpCookieCollection Cookies { get; }

        byte[] Content { get; }

        void AddHeader(HttpHeader header);

        byte[] GetBytes();

        void AddCookie(HttpCookie cookie);
    }
}
