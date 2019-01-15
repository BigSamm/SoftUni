using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Console.ReadLine();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            
            double price = 0;
            switch(t)
            {
                case "Premiere": price = (r * c * 12); break;
                case "Normal": price = (r * c * 7.5); break;
                case "Discount": price = (r * c * 5); break;
            }

            Console.WriteLine("{0:f2} leva", price);

        }
    }
}
