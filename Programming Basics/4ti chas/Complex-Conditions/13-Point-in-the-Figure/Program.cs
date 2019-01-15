using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var result = "";
            if (x > 0 && x < 3 * h && y > 0 && y < h)
                result = "Inside";
            else if (x > h && x < 2 * h && y > 0 && y < 4 * h)
                result = "Inside";
            else if ((y == 0 && x >= 0 && x <= 3 * h) ||
                     (x == 0 && y >= 0 && y <= h) ||
                     (y == h && x >= 0 && x <= h) ||
                     (x == h && y >= h && y <= 4 * h) ||
                     (y == 4 * h && x >= h && x <= 2 * h) ||
                     (x == 2 * h && y >= h && y <= 4 * h) ||
                     (y == h && x >= 2 * h && x <= 3 * h) ||
                     (x == 3 * h && y >= 0 && y <= h))
                result = "Border";
            else result = "Outside";
            Console.WriteLine(result);
        }
    }
}
