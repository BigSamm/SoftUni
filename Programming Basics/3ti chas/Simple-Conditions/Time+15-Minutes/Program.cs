using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            min += 15;
            if (min >= 60)
            {
                h += 1;
                min = min - 60;
            }
            if (h > 23) h = 0;
            
            Console.WriteLine("{0}:{1:D2}", h, min);
        }
    }
}
