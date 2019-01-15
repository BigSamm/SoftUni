using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var startEnd = 1;
            var mid = 2 * n - 1;

            if (n % 2 == 1)
            {


                for (int i = 0; i < n; i++)
                {
                    Console.Write(new string('*', startEnd));
                    Console.Write(@"\");
                    Console.Write(new string('-', mid));
                    Console.Write("/");
                    Console.WriteLine(new string('*', startEnd));
                    startEnd++;
                    mid -= 2;
                }

                var a = (n - 1) / 2;
                var b = n;
                for (int i = 0; i < (n + 1) / 4.0; i++)
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
                mid = 2 * n - 1;
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

             //int q = 9;
             //Console.WriteLine("{0}",(q + 1) / 4);
        }
    }
}
