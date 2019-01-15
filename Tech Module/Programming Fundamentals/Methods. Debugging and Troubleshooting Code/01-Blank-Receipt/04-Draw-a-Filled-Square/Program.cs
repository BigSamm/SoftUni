using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintHeaderOrFooter(n);
            PrintMiddleRows(n);
            PrintHeaderOrFooter(n);
        }
    
        static void PrintHeaderOrFooter(int n)
        {
            Console.WriteLine(new string('-', 2*n));
        }

        static void PrintMiddleRows(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('-');
                for (int h = 0; h < n - 1; h++)
                {
                    Console.Write(@"\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}
