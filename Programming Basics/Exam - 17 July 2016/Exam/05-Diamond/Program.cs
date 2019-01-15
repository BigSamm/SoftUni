using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var startEnd = n - 1;
            var mid = 3 * n;

            Console.Write(new string('.', n));
            Console.Write(new string('*', mid));
            Console.WriteLine(new string('.', n));
            
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', startEnd));
                Console.Write("*");
                Console.Write(new string('.', mid));
                Console.Write("*");
                Console.WriteLine(new string('.', startEnd));
                startEnd--;
                mid += 2;
            }

            Console.WriteLine(new string('*', 5 * n));

            for (int i = 0; i < 2 * n; i++)
            {
                startEnd++;
                mid -= 2;
                Console.Write(new string('.', startEnd));
                Console.Write("*");
                Console.Write(new string('.', mid));
                Console.Write("*");
                Console.WriteLine(new string('.', startEnd));
            }

            startEnd++;
            Console.Write(new string('.', startEnd));
            Console.Write(new string('*', mid));
            Console.WriteLine(new string('.', startEnd));

        }
    }
}
