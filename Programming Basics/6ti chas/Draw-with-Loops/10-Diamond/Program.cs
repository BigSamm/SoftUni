using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lr = (n - 1) / 2;
            var mid = n - (2 * lr) - 2;

            if (n % 2 == 1)
            {
                for (int row = 1; row <= (n + 1) / 2; row++)
                {
                    Console.Write(new string('-', lr));
                    Console.Write("*");
                    if(mid < 0) Console.Write(new string('-', lr));
                    else if (mid >= 0)
                    {
                        Console.Write(new string('-', mid));
                        Console.Write("*");
                        Console.Write(new string('-', lr));
                    }
                    Console.WriteLine();
                    lr--;
                    mid+=2;
                }
                mid -= 4;
                lr += 2;
                for (int row = 1; row <= (n - 1) / 2; row++)
                {
                    Console.Write(new string('-', lr));
                    Console.Write("*");
                    if(mid >= 0)
                    {
                        Console.Write(new string('-', mid));
                        Console.Write("*");
                        Console.Write(new string('-', lr));
                    }
                    else if (mid < 0) Console.Write(new string('-', lr));
                    Console.WriteLine();
                    lr++;
                    mid -= 2;
                }
            }


            else if (n % 2 == 0)
            {
                for (int row = 1; row <= (n + 1) / 2; row++)
                {
                    Console.Write(new string('-', lr));
                    if (mid < 0)
                    {
                        Console.Write("**");
                        Console.Write(new string('-', lr));
                    }
                    else if (mid >= 0)
                    {
                        Console.Write("*");
                        Console.Write(new string('-', mid));
                        Console.Write("*");
                        Console.Write(new string('-', lr));
                    }
                    Console.WriteLine();
                    lr--;
                    mid += 2;
                }
                mid -= 4;
                lr += 2;
                for (int row = 1; row <= (n - 1) / 2; row++)
                {
                    Console.Write(new string('-', lr));
                    if (mid >= 0)
                    {
                        Console.Write("*");
                        Console.Write(new string('-', mid));
                        Console.Write("*");
                        Console.Write(new string('-', lr));
                    }
                    else if (mid < 0)
                    {
                        Console.Write("**");
                        Console.Write(new string('-', lr));
                    }
                    Console.WriteLine();
                    lr++;
                    mid -= 2;
                }
            }


        }
    }
}
