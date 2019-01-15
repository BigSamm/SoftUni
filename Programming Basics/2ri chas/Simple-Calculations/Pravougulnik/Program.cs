using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pravougulnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1= ");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("y1= ");
            var y1 = double.Parse(Console.ReadLine());
            Console.Write("x2= ");
            var x2 = double.Parse(Console.ReadLine());
            Console.Write("y2= ");
            var y2 = double.Parse(Console.ReadLine());
            var perimeter = ((Math.Max(x1, x2) - Math.Min(x1, x2)) + (Math.Max(y1, y2) - Math.Min(y1, y2))) * 2;
            var area = (Math.Max(x1, x2) - Math.Min(x1, x2)) * (Math.Max(y1, y2) - Math.Min(y1, y2));
            Console.Write("area= ");
            Console.WriteLine(area);
            Console.Write("perimeter= ");
            Console.WriteLine(perimeter);


        }
    }
}
