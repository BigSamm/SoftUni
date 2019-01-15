namespace SIS.Framework.Routers
{
    using System.IO;
    using System.Net;

    using HTTP.Requests.Contracts;
    using HTTP.Responses.Contracts;
    using HTTP.Responses;
    using WebServer.Contracts.Api;
    using WebServer.Results;

    public class ResourceRouter : IHttpHandler
    {
        public IHttpResponse Handle(IHttpRequest request)
        {
            var httpRequestPath = request.Path;

            var indexOfStartOfExtension = httpRequestPath.LastIndexOf('.');
            var indexOfStartOfNameOfResource = httpRequestPath.LastIndexOf('/');
            // users/login/bootstrap.css

            var requestPathExtension = httpRequestPath
                .Substring(indexOfStartOfExtension);

            var resourceName = httpRequestPath
                .Substring(
                    indexOfStartOfNameOfResource);

            var resourcePath = MvcContext.Get.RootDirectoryRelativePath
                               + $"/{MvcContext.Get.ResourceFolderName}"
                               + $"/{requestPathExtension.Substring(1)}"
                               + resourceName;

            if (!File.Exists(resourcePath))
            {
                return new HttpResponse(HttpStatusCode.NotFound);
            }

            var fileContent = File.ReadAllBytes(resourcePath);

            return new InlineResourceResult(fileContent, HttpStatusCode.OK);
        }
    }
}