namespace SIS.HTTP.Cookies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Exceptions;

    class HttpCookieCollection : IHttpCookieCollection
    {
        private readonly Dictionary<string, HttpCookie> cookies;

        public HttpCookieCollection()
        {
            this.cookies = new Dictionary<string, HttpCookie>();
        }

        public void Add(HttpCookie cookie)
        {
            if (cookie == null)
                throw new BadRequestException();

            this.cookies[cookie.Key] = cookie;
        }

        public bool ContainsCookie(string key)
        {
            if (String.IsNullOrEmpty(key))
                throw new BadRequestException();

            bool result = this.cookies.ContainsKey(key);
            return result;
        }

        public HttpCookie GetCookie(string key)
        {
            if (String.IsNullOrEmpty(key))
                throw new BadRequestException();

            if (!this.ContainsCookie(key))
                return null;

            HttpCookie cookie = this.cookies[key];
            return cookie;
        }

        public bool HasCookies()
        {
            bool result = this.cookies.Any();
            return result;
        }

        public override string ToString()
        {
            string result = String.Join("; ", this.cookies.Values);
            return result;
        }
    }
}
