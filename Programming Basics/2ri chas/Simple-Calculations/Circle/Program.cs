using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("r= ");
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;
            Console.Write("area= ");
            Console.WriteLine(area);
            Console.Write("perimeter= ");
            Console.WriteLine(perimeter);
        }
    }
}
