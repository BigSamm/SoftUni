using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Math.Abs(int.Parse(Console.ReadLine()));
            var b = Math.Abs(int.Parse(Console.ReadLine()));

            while(b != 0)
            {
                var oldB = b;
                b = a % b;
                a = oldB;
            }
            Console.WriteLine(a);

        }
    }
}
