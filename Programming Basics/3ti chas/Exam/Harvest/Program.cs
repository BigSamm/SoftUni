using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var grapes = x * y;
            var vine = grapes * 0.4 / 2.5;
            if (vine >= z)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(vine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(vine - z), Math.Ceiling((vine - z) / workers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(z - vine));
            }


        }
    }
}
