using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine().Split(':').Select(long.Parse).ToList();
            long steps = long.Parse(Console.ReadLine());
            long timeForOneStep = long.Parse(Console.ReadLine());

            long timeOutside = steps * timeForOneStep;
            long hours = time[0];
            long mins = time[1];
            long secs = time[2];

            secs += timeOutside;
            mins += secs / 60;
            secs %= 60;
            hours += mins / 60;
            mins %= 60;
            hours %= 24;

            Console.WriteLine($"Time Arrival: {hours:d2}:{mins:d2}:{secs:d2}");
        }
    }
}
