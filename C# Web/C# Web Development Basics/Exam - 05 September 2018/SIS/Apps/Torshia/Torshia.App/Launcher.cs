using SIS.Framework;

namespace Torshia.App
{
    class Launcher
    {
        static void Main()
        {
            WebHost.Start(new StartUp());
        }
    }
}