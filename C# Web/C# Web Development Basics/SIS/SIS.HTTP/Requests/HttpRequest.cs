namespace SIS.HTTP.Requests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    using Common;
    using Cookies;
    using Cookies.Contracts;
    using Enums;
    using Headers;
    using Headers.Contracts;
    using Requests.Contracts;
    using Exceptions;
    using SIS.HTTP.Sessions.Contracts;

    public class HttpRequest : IHttpRequest
    {
        public HttpRequest(string requestString)
        {
            this.FormData = new Dictionary<string, object>();
            this.QueryData = new Dictionary<string, object>();
            this.Headers = new HttpHeaderCollection();
            this.Cookies = new HttpCookieCollection();

            this.ParseRequest(requestString);
        }

        public string Path { get; private set; }

        public string Url { get; private set; }

        public Dictionary<string, object> FormData { get; }

        public Dictionary<string, object> QueryData { get; }

        public IHttpHeaderCollection Headers { get; }

        public IHttpCookieCollection Cookies { get; }

        public HttpRequestMethod RequestMethod { get; private set; }

        public IHttpSession Session { get; set; }

        private void ParseRequest(string requestString)
        {
            string[] splitRequestContent = requestString.Split(Environment.NewLine);

            string[] requestLine = splitRequestContent[0].Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (!this.IsValidRequestLine(requestLine))
                throw new BadRequestException();

            this.ParseRequestMethod(requestLine);
            this.ParseRequestUrl(requestLine);
            this.ParseRequestPath();

            this.ParseHeaders(splitRequestContent.Skip(1).ToArray());
            this.ParseCookies();

            bool requestHasBody = splitRequestContent.Length > 1;
            this.ParseRequestParameters(splitRequestContent[splitRequestContent.Length - 1], requestHasBody);
        }

        private void ParseCookies()
        {
            if (!this.Headers.ContainsHeader("Cookie"))
                return;

            string cookiesString = this.Headers.GetHeader("Cookie").Value;

            if (String.IsNullOrEmpty(cookiesString))
                return;

            string[] splitCookies = cookiesString.Split("; ");

            foreach (string splitCookie in splitCookies)
            {
                string[] cookieParts = splitCookie.Split('=', 2, StringSplitOptions.RemoveEmptyEntries);

                if (cookieParts.Length != 2)
                    continue;

                string key = cookieParts[0];
                string value = cookieParts[1];

                this.Cookies.Add(new HttpCookie(key, value, false));
            }
        }

        private void ParseRequestParameters(string bodyParams, bool requestHasBody)
        {
            this.ParseQueryParameters();

            if (requestHasBody)
            {
                this.ParseFormDataParameters(bodyParams);
            }
        }

        private void ParseFormDataParameters(string formData)
        {
            var paramethers = formData.Split('&', StringSplitOptions.RemoveEmptyEntries);
            foreach (var param in paramethers)
            {
                var tokens = param.Split('=', StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length != 2)
                {
                    return;
                }

                var key = tokens[0];
                var value = tokens[1];

                this.FormData.Add(key, value);
            }
        }

        private void ParseQueryParameters()
        {
            var pattern = @"\?[^#]*(?=$|#)";
            var match = Regex.Match(this.Url, pattern);
            if (match.Success == false)
            {
                return;
            }

            string queryString = match.Groups[0].Value.Substring(1);
            var subQueries = queryString.Split("&", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < subQueries.Length; i++)
            {
                var subQueryTokens = subQueries[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                if (subQueryTokens.Length != 2)
                {
                    continue;
                }
                var key = subQueryTokens[0];
                var value = subQueryTokens[1];

                this.QueryData.Add(key, value);
            }
        }

        private void ExtractRequestParams(string[] paramKeyValuePairs, Dictionary<string, object> paramsCollection)
        {
            foreach (string paramKeyValuePair in paramKeyValuePairs)
            {
                // key=value
                string[] keyValuePair = paramKeyValuePair.Split('=', StringSplitOptions.RemoveEmptyEntries);

                if (keyValuePair.Length != 2)
                    throw new BadRequestException();

                string paramKey = keyValuePair[0];
                string paramValue = keyValuePair[1];

                paramsCollection[paramKey] = paramValue;
            }
        }

        private void ParseHeaders(string[] requestHeaders)
        {
            if (!requestHeaders.Any())
                throw new BadRequestException();

            foreach (string requestHeader in requestHeaders)
            {
                if (String.IsNullOrEmpty(requestHeader))
                    return;

                string[] splitRequestHeader = requestHeader.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string requestHeaderKey = splitRequestHeader[0];
                string requestHeaderValue = splitRequestHeader[1];

                this.Headers.Add(new HttpHeader(requestHeaderKey, requestHeaderValue));
            }
        }

        private void ParseRequestPath()
        {
            string path = this.Url.Split('?').FirstOrDefault();

            if (String.IsNullOrEmpty(path))
                throw new BadRequestException();

            this.Path = path;
        }

        private void ParseRequestUrl(string[] requestLine)
        {
            if (String.IsNullOrEmpty(requestLine[1]))
                throw new BadRequestException();

            this.Url = requestLine[1];
        }

        private void ParseRequestMethod(string[] requestLine)
        {
            bool parseResult = Enum.TryParse<HttpRequestMethod>(requestLine[0], true, out var requestMethod);

            if (!parseResult)
                throw new BadRequestException();

            this.RequestMethod = requestMethod;
        }

        private bool IsValidRequestLine(string[] requestLine)
        {
            if (requestLine.Length == 3 && requestLine[2] == GlobalConstants.HttpOneProtocolFragment)
                return true;

            return false;
        }
    }
}