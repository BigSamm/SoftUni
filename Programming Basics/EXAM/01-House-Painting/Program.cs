
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var zadna = x * x;
            var predna = (x * x) - (1.2 * 2);
            var stranichni = ((x * y) - (1.5 * 1.5)) * 2;
            var pokriv = (2 * x * y) + ((x * h) / 2) * 2;

            var zelenaBoq = (zadna + predna + stranichni) / 3.4;
            var chervenaBoq = pokriv / 4.3;

            Console.WriteLine("{0:f2}", zelenaBoq);
            Console.WriteLine("{0:f2}", chervenaBoq);




        }
    }
}
