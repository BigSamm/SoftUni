using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var mins= int.Parse(Console.ReadLine());

            mins += 30;
            if (mins >= 60)
            {
                hours++;
                mins -= 60;
            }
            if (hours == 24)
                hours = 0;

            Console.WriteLine("{0}:{1:d2}", hours, mins);
        }
    }
}
