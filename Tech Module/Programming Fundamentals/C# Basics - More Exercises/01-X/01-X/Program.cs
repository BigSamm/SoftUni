using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_X
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var startEnd = 0;
            var mid = n - 2;

            for (int i = 0; i < (n-1)/2; i++)
            {
                Console.Write(new string(' ', startEnd));
                Console.Write("x");
                Console.Write(new string(' ', mid));
                Console.Write("x");
                Console.WriteLine(new string(' ', startEnd));
                startEnd++;
                mid -= 2;
            }

            Console.Write(new string(' ', startEnd));
            Console.Write("x");
            Console.WriteLine(new string(' ', startEnd));

            startEnd--;
            mid += 2;

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.Write(new string(' ', startEnd));
                Console.Write("x");
                Console.Write(new string(' ', mid));
                Console.Write("x");
                Console.WriteLine(new string(' ', startEnd));
                startEnd--;
                mid += 2;
            }

        }
    }
}
