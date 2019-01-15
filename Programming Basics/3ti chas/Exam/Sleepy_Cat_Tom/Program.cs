using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleepy_Cat_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            var freeDays = int.Parse(Console.ReadLine());

            var minsPlay = (freeDays * 127) + ((365 - freeDays) * 63);
            var a = 30000 - minsPlay;

            if (a >= 0)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", a / 60, a % 60);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", Math.Abs(a / 60), Math.Abs(a % 60));
            }


        }
    }
}
