using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            var b = long.Parse(Console.ReadLine());
            long price = 0;

            if (a <= 127)
                price += 4 * a;
            else
                price += 10 * a;

            if (b <= 127)
                price += 4 * b;
            else
                price += 10 * b;

            Console.WriteLine(price);
        }
    }
}
