using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("radians= ");
            var rad = double.Parse(Console.ReadLine());
            var deg = Math.Round((180 / Math.PI) * rad, 0);
            Console.Write("degrees= ");
            Console.WriteLine(deg);
        }
    }
}
