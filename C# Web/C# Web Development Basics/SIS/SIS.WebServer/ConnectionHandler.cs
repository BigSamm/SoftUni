namespace SIS.WebServer
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading.Tasks;

    using Contracts.Api;
    using HTTP.Common;
    using HTTP.Cookies;
    using HTTP.Requests;
    using HTTP.Requests.Contracts;
    using HTTP.Responses;
    using HTTP.Responses.Contracts;
    using HTTP.Sessions;
    using Results;
    using Routing;
    using SIS.HTTP.Exceptions;

    //public class ConnectionHandler
    //{
    //    private readonly Socket client;

    //    private readonly ServerRoutingTable serverRoutingTable;

    //    private readonly IHttpHandler handler;

    //    private const string RootDirectoryRelativePath = "../../../";

    //    public ConnectionHandler(Socket client, ServerRoutingTable serverRoutingTable)
    //    {
    //        this.client = client;
    //        this.serverRoutingTable = serverRoutingTable;
    //    }

    //    public ConnectionHandler(Socket client, IHttpHandler handler)
    //    {
    //        this.client = client;
    //        this.handler = handler;
    //    }

    //    private async Task<IHttpRequest> ReadRequest()
    //    {
    //        var result = new StringBuilder();
    //        var data = new ArraySegment<byte>(new byte[1024]);

    //        while (true)
    //        {
    //            int numberOfBytesRead = await this.client.ReceiveAsync(data.Array, SocketFlags.None);

    //            if (numberOfBytesRead == 0)
    //                break;

    //            string bytesAsString = Encoding.UTF8.GetString(data.Array, 0, numberOfBytesRead);
    //            result.Append(bytesAsString);

    //            if (numberOfBytesRead < 1023)
    //                break;
    //        }

    //        if (result.Length == 0)
    //            return null;

    //        return new HttpRequest(result.ToString());
    //    }

    //    private IHttpResponse HandleRequest(IHttpRequest httpRequest)
    //    {
    //        //if (this.serverRoutingTable == null)
    //        return this.handler.Handle(httpRequest);

    //        //bool isResourceRequest = this.IsResourceRequest(httpRequest);
    //        //if (isResourceRequest)
    //        //{
    //        //    return this.HandleRequestResponse(httpRequest.Path);
    //        //}

    //        //if (!this.serverRoutingTable.Routes.ContainsKey(httpRequest.RequestMethod) ||
    //        //    !this.serverRoutingTable.Routes[httpRequest.RequestMethod].ContainsKey(httpRequest.Path))
    //        //{
    //        //    return new HttpResponse(HttpStatusCode.NotFound);
    //        //}

    //        //return this.serverRoutingTable.Routes[httpRequest.RequestMethod][httpRequest.Path].Invoke(httpRequest);
    //    }

    //    private IHttpResponse HandleRequestResponse(string requestPath)
    //    {
    //        int indexOfStartOfExtension = requestPath.LastIndexOf('.');
    //        int indexOfStartOfNameOfResource = requestPath.LastIndexOf('/');

    //        string requestPathExtension = requestPath.Substring(indexOfStartOfExtension);

    //        string resourceName = requestPath.Substring(indexOfStartOfNameOfResource);

    //        string resourcePath = RootDirectoryRelativePath + "Resources/" +
    //            requestPathExtension.Substring(1) + resourceName;

    //        if (!File.Exists(resourcePath))
    //            return new HttpResponse(HttpStatusCode.NotFound);

    //        byte[] fileContent = File.ReadAllBytes(resourcePath);

    //        return new InlineResourceResult(fileContent, HttpStatusCode.OK);
    //    }

    //    private bool IsResourceRequest(IHttpRequest httpRequest)
    //    {
    //        string requestPath = httpRequest.Path;

    //        if (requestPath.Contains('.'))
    //        {
    //            string requestPathExtension = requestPath.Substring(requestPath.LastIndexOf('.'));
    //            return GlobalConstants.ResourceExtensions.Contains(requestPathExtension);
    //        }

    //        return false;
    //    }

    //    private async Task PrepareResponse(IHttpResponse httpResponse)
    //    {
    //        byte[] byteSegments = httpResponse.GetBytes();

    //        await this.client.SendAsync(byteSegments, SocketFlags.None);
    //    }

    //    public async Task ProcessRequestAsync()
    //    {
    //        IHttpRequest httpRequest = await this.ReadRequest();

    //        if (httpRequest != null)
    //        {
    //            string sessionId = this.SetRequestSession(httpRequest);

    //            IHttpResponse httpResponse = this.HandleRequest(httpRequest);

    //            this.SetResponseSession(httpResponse, sessionId);

    //            await this.PrepareResponse(httpResponse);
    //        }

    //        this.client.Shutdown(SocketShutdown.Both);
    //    }

    //    private string SetRequestSession(IHttpRequest httpRequest)
    //    {
    //        string sessionId = null;

    //        if (httpRequest.Cookies.ContainsCookie(HttpSessionStorage.SessionCookieKey))
    //        {
    //            HttpCookie cookie = httpRequest.Cookies.GetCookie(HttpSessionStorage.SessionCookieKey);
    //            sessionId = cookie.Value;
    //            httpRequest.Session = HttpSessionStorage.GetSession(sessionId);
    //        }
    //        else
    //        {
    //            sessionId = Guid.NewGuid().ToString();
    //            httpRequest.Session = HttpSessionStorage.GetSession(sessionId);
    //        }

    //        return sessionId;
    //    }

    //    private void SetResponseSession(IHttpResponse httpResponse, string sessionId)
    //    {
    //        if (sessionId != null)
    //        {
    //            httpResponse.AddCookie(
    //                new HttpCookie(
    //                    HttpSessionStorage.SessionCookieKey, $"{sessionId};HttpOnly=true"));
    //        }
    //    }
    //}

    public class ConnectionHandler
    {
        private readonly Socket client;

        private const string RootDirectoryRelativePath = "../../..";

        private readonly IHttpHandlingContext handlersContext;

        public ConnectionHandler(Socket client, IHttpHandlingContext handlersContext)
        {
            CoreValidator.ThrowIfNull(client, nameof(client));
            CoreValidator.ThrowIfNull(handlersContext, nameof(handlersContext));

            this.client = client;
            this.handlersContext = handlersContext;
        }

        private async Task<IHttpRequest> ReadRequest()
        {
            var result = new StringBuilder();
            var data = new ArraySegment<byte>(new byte[1024]);

            while (true)
            {
                int numberOfBytesRead = await this.client.ReceiveAsync(data.Array, SocketFlags.None);

                if (numberOfBytesRead == 0)
                {
                    break;
                }

                var bytesAsString = Encoding.UTF8.GetString(data.Array, 0, numberOfBytesRead);
                result.Append(bytesAsString);

                if (numberOfBytesRead < 1023)
                {
                    break;
                }
            }

            if (result.Length == 0)
            {
                return null;
            }

            return new HttpRequest(result.ToString());
        }

        private async Task PrepareResponse(IHttpResponse httpResponse)
        {
            byte[] byteSegments = httpResponse.GetBytes();

            await this.client.SendAsync(byteSegments, SocketFlags.None);
        }

        private string SetRequestSession(IHttpRequest httpRequest)
        {
            string sessionId = null;

            if (httpRequest.Cookies.ContainsCookie(HttpSessionStorage.SessionCookieKey))
            {
                var cookie = httpRequest.Cookies.GetCookie(HttpSessionStorage.SessionCookieKey);
                sessionId = cookie.Value;
                httpRequest.Session = HttpSessionStorage.GetSession(sessionId);
            }
            else
            {
                sessionId = Guid.NewGuid().ToString();
                httpRequest.Session = HttpSessionStorage.GetSession(sessionId);
            }

            return sessionId;
        }

        private void SetResponseSession(IHttpResponse httpResponse, string sessionId)
        {
            if (sessionId != null)
            {
                httpResponse
                    .AddCookie(new HttpCookie(HttpSessionStorage.SessionCookieKey
                        , sessionId));
            }
        }

        public async Task ProcessRequestAsync()
        {
            try
            {
                var httpRequest = await this.ReadRequest();

                if (httpRequest != null)
                {
                    string sessionId = this.SetRequestSession(httpRequest);

                    var httpResponse = this.handlersContext.Handle(httpRequest);

                    this.SetResponseSession(httpResponse, sessionId);

                    await this.PrepareResponse(httpResponse);
                }
            }
            catch (BadRequestException e)
            {
                await this.PrepareResponse(new TextResult(e.Message, HttpStatusCode.BadRequest));
            }
            catch (Exception e)
            {
                await this.PrepareResponse(new TextResult(e.Message, HttpStatusCode.InternalServerError));
            }

            this.client.Shutdown(SocketShutdown.Both);
        }
    }
}