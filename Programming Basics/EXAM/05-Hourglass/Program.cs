using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var startEnd = 2;
            var mid = (2 * n + 1) - (2 * startEnd) - 2;

            Console.WriteLine(new string('*', 2 * n + 1));

            Console.Write(".");
            Console.Write("*");
            Console.Write(new string(' ', 2 * n - 3));
            Console.Write("*");
            Console.WriteLine(".");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(new string('.', startEnd));
                Console.Write("*");
                Console.Write(new string('@', mid));
                Console.Write("*");
                Console.WriteLine(new string('.', startEnd));
                startEnd++;
                mid -= 2;
            }

            Console.Write(new string('.', n));
            Console.Write("*");
            Console.WriteLine(new string('.', n));

            startEnd--;
            mid = 0;
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(new string('.', startEnd));
                Console.Write("*");
                Console.Write(new string(' ', mid));
                Console.Write("@");
                Console.Write(new string(' ', mid));
                Console.Write("*");
                Console.WriteLine(new string('.', startEnd));
                mid++;
                startEnd--;
            }

            Console.Write(".");
            Console.Write("*");
            Console.Write(new string('@', 2 * mid + 1));
            Console.Write("*");
            Console.WriteLine(".");

            Console.WriteLine(new string('*', 2*n+1));

        }
    }
}
