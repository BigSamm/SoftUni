using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write(@"\");
            Console.Write(new string('_', (n - n/2 - 2)*2));
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.WriteLine(@"\");

            if(n <= 4)
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("|");
                Console.Write(new string(' ', 2 * n - 2));
                Console.WriteLine("|");
            }
            else
            {
                for (int i = 0; i < n - 3; i++)
                {
                    Console.Write("|");
                    Console.Write(new string(' ', 2 * n - 2));
                    Console.WriteLine("|");
                }
                Console.Write("|");
                Console.Write(new string(' ', n/2 + 1));
                Console.Write(new string('_', (n - n / 2 - 2) * 2));
                Console.Write(new string(' ', n / 2 + 1));
                Console.WriteLine("|");
            }

            Console.Write(@"\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            Console.Write(new string(' ', (n - n / 2 - 2) * 2));
            Console.Write(@"\");
            Console.Write(new string('_', n / 2));
            Console.WriteLine("/");
            
        }
    }
}
