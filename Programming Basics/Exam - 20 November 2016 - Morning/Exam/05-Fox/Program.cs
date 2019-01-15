using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int startEnd = 1;
            int mid = 2 * n - 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*',startEnd));
                Console.Write(@"\");
                Console.Write(new string('-', mid));
                Console.Write("/");
                Console.WriteLine(new string('*', startEnd));
                startEnd++;
                mid -= 2;
            }

            int a = (n - 1) / 2;
            int b = n;
            for (int i = 0; i < Math.Truncate((double)n / 3); i++)
            {
                Console.Write("|");
                Console.Write(new string('*', a));
                Console.Write(@"\");
                Console.Write(new string('*', b));
                Console.Write("/");
                Console.Write(new string('*', a));
                Console.WriteLine("|");
                a++;
                b -= 2;
            }

            startEnd = 1;
            mid =  2 * n - 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', startEnd));
                Console.Write(@"\");
                Console.Write(new string('*', mid));
                Console.Write("/");
                Console.WriteLine(new string('-', startEnd));
                startEnd++;
                mid -= 2;
            }





        }
    }
}
