using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
                var num = int.Parse(Console.ReadLine());
                var m = (num % 10) + (num / 100);
                var n = (num / 100) + ((num / 10) % 10);
                var result = num;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (result % 5 == 0)
                        {
                            result -= num / 100;
                            Console.Write(result + " ");
                        }
                        else if (result % 3 == 0)
                        {
                            result -= (num / 10) % 10;
                            Console.Write(result + " ");
                        }
                        else
                        {
                            result += num % 10;
                            Console.Write(result + " ");
                        }
                    }
                    Console.WriteLine();
                }


            



        }
    }
}
