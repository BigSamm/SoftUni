namespace SIS.HTTP.Sessions
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    using Exceptions;

    class HttpSession : IHttpSession
    {
        private readonly Dictionary<string, object> sessionParameters;

        public HttpSession(string id)
        {
            this.Id = id;

            this.sessionParameters = new Dictionary<string, object>();
        }

        public string Id { get; }

        public void AddParameter(string name, object parameter)
        {
            if (String.IsNullOrEmpty(name) || parameter == null)
                throw new BadRequestException();
           
            this.sessionParameters[name] = parameter;
        }

        public void ClearParameters()
        {
            this.sessionParameters.Clear();
        }

        public bool ContainsParameter(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new BadRequestException();

            bool result = this.sessionParameters.ContainsKey(name);
            return result;
        }

        public object GetParameter(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new BadRequestException();

            if (!this.ContainsParameter(name))
                return null;

            object parameter = this.sessionParameters[name];
            return parameter;
        }
    }
}
