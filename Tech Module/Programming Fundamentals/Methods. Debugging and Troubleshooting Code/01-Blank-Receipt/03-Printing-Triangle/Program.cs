using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintUpperLines(num);
            PrintLowerLines(num);
        }
        
        static void PrintUpperLines(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                for (int h = 1; h <= i; h++)
                {
                    Console.Write(h + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintLowerLines(int end)
        {
            for (int i = end - 1; i >= 1; i--)
            {
                for (int h = 1; h <= i; h++)
                {
                    Console.Write(h + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
