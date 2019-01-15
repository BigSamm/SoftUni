namespace SIS.HTTP.Headers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;

    public class HttpHeaderCollection : IHttpHeaderCollection
    {
        private readonly IDictionary<string, HttpHeader> headers;

        public HttpHeaderCollection()
        {
            this.headers = new Dictionary<string, HttpHeader>();
        }

        public void Add(HttpHeader header)
        {
            if (header == null ||
                String.IsNullOrEmpty(header.Key) ||
                String.IsNullOrEmpty(header.Value) ||
                this.ContainsHeader(header.Key))
            {
                throw new ArgumentException();
            }

            this.headers[header.Key] = header;
        }

        public bool ContainsHeader(string key)
        {
            if (String.IsNullOrEmpty(key))
                throw new ArgumentException();

            bool result = this.headers.ContainsKey(key);
            return result;
        }

        public HttpHeader GetHeader(string key)
        {
            if (String.IsNullOrEmpty(key))
                throw new ArgumentException();

            if (!this.ContainsHeader(key))
                return null;

            HttpHeader result = this.headers[key];
            return result;
        }

        public override string ToString()
        {
            string result = String.Join(Environment.NewLine, this.headers.Values);
            return result;
        }
    }
}
