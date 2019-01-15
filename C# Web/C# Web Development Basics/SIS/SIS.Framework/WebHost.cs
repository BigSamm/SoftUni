namespace SIS.Framework
{
    using Api.Contracts;
    using Framework.Routers;
    using Services;
    using Services.Contracts;
    using WebServer;
    using WebServer.Contracts.Api;

    public static class WebHost
    {
        private const int HostingPort = 80;

        public static void Start(IMvcApplication application)
        {
            IDependencyContainer container = new DependencyContainer();
            application.ConfigureServices(container);

            IHttpHandler controllerRouter = new ControllerRouter(container);

            application.Configure();

            var handlingContext = new HttpRouteHandlingContext(new ControllerRouter(container), new ResourceRouter());
            var server = new Server(HostingPort, handlingContext);
            MvcEngine.Run(server);
        }
    }
}