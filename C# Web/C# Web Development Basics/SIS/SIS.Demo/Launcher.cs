namespace SIS.Demo
{
    using Framework;
    using Framework.Routers;
    using WebServer;

    class Launcher
    {
        static void Main()
        {
            var server = new WebServer(80, new ControllerRouter());

            MvcEngine.Run(server);
        }
    }
}