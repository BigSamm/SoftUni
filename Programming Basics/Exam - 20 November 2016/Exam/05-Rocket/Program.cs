using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var startEnd = ((3 * n) - 2) / 2;
            var mid = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', startEnd));
                Console.Write("/");
                Console.Write(new string(' ', mid));
                Console.Write(@"\");
                Console.WriteLine(new string('.', startEnd));
                startEnd--;
                mid += 2;
            }

            startEnd++;
            Console.Write(new string('.', startEnd));
            Console.Write(new string('*', mid));
            Console.WriteLine(new string('.', startEnd));

            mid -= 2;
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(new string('.', startEnd));
                Console.Write("|");
                for (int j = 0; j < mid; j++) Console.Write(@"\");
                Console.Write("|");
                Console.WriteLine(new string('.', startEnd));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', startEnd));
                Console.Write("/");
                Console.Write(new string('*', mid));
                Console.Write(@"\");
                Console.WriteLine(new string('.', startEnd));
                mid += 2;
                startEnd--;
            }


        }
    }
}
