using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            var flaps = int.Parse(Console.ReadLine());
            var distance = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            double traveledDist = flaps / 1000.0 * distance;
            int time = (flaps / 100) + ((flaps / endurance) * 5);

            Console.WriteLine($"{traveledDist:f2} m.");
            Console.WriteLine($"{time} s.");
        }
    }
}
