using SIS.MvcFramework;

namespace Chushka.App
{
    public class Launcher
    {
        public static void Main()
        {
            WebHost.Start(new StartUp());
        }
    }
}
