using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("h= ");
            var h = double.Parse(Console.ReadLine());
            var result = (a + b) / 2 * h;
            Console.WriteLine(result);
        }
    }
}
