using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var mid = 0;
            var end = 2 * n - 2;
            var start = 3 * n;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', start));
                Console.Write('*');
                Console.Write(new string('-', mid));
                Console.Write('*');
                Console.WriteLine(new string('-', end));
                mid++;
                end--;
            }

            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('*', start + 1));
                Console.Write(new string('-', mid - 1));
                Console.Write('*');
                Console.WriteLine(new string('-' , end + 1));
            }

            for (int i = 1; i <= n / 2; i++)
            {
                if (i != n / 2)
                {
                    Console.Write(new string('-', start));
                    Console.Write('*');
                    Console.Write(new string('-', mid - 1));
                    Console.Write('*');
                    Console.WriteLine(new string('-', end + 1));
                }
                else if(i == n / 2)
                {
                    Console.Write(new string('-', start));
                    Console.Write('*');
                    Console.Write(new string('*', mid - 1));
                    Console.Write('*');
                    Console.WriteLine(new string('-', end + 1));
                }
                start--;
                end--;
                mid += 2;
                
            }
            



        }
    }
}
