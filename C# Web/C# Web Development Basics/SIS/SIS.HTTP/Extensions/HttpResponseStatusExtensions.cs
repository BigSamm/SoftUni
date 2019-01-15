namespace SIS.HTTP.Extensions
{
    using System.Net;

    public static class HttpResponseStatusExtensions
    {
        public static string GetResponseLine(this HttpStatusCode statusCode)
        {
            string result = $"{(int)statusCode} {statusCode}";
            return result;
        }
    }
}
