using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var mins = float.Parse(Console.ReadLine());
            var sec = float.Parse(Console.ReadLine());

            mins += hours * 60;
            float allSec = sec + (mins * 60);
            float allHours = allSec / 60 / 60;

            float metersPerSec = (distance / allSec);
            float kmPerHour = (distance / 1000 / allHours);
            float milesPerHour = (distance / 1609 / allHours);

            Console.WriteLine(metersPerSec);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(milesPerHour);

        }
    }
}
