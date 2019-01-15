using SIS.MvcFramework;

namespace MishMash.App
{
    public class Launcher
    {
        static void Main()
        {
            WebHost.Start(new StartUp());
        }
    }
}