using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= (2 * (n - 2) + 1) / 2; i++)
            {
                    if (i % 2 == 1)
                    {
                        Console.Write(new string('*', n - 2));
                        Console.Write(@"\");
                        Console.Write(" ");
                        Console.Write("/");
                        Console.WriteLine(new string('*', n - 2));
                    }

                    else if (i % 2 == 0)
                    {
                        Console.Write(new string('-', n - 2));
                        Console.Write(@"\");
                        Console.Write(" ");
                        Console.Write("/");
                        Console.WriteLine(new string('-', n - 2));
                    }
            }

                    Console.Write(new string(' ', n - 1));
                    Console.Write("@");
                    Console.WriteLine(new string(' ', n - 1));
                
            for (int i = 1; i <= (2 * (n - 2) + 1) / 2; i++)
            {
                    if (i % 2 == 1)
                    {
                        Console.Write(new string('*', n - 2));
                        Console.Write("/");
                        Console.Write(" ");
                        Console.Write(@"\");
                        Console.WriteLine(new string('*', n - 2));
                    }

                    else if (i % 2 == 0)
                    {
                        Console.Write(new string('-', n - 2));
                        Console.Write("/");
                        Console.Write(" ");
                        Console.Write(@"\");
                        Console.WriteLine(new string('-', n - 2));
                    }
            }



            
        }
    }
}
