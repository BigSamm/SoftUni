using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (int row = 1; row <= (n + 1) / 2; row++)
                {
                    for (int j = (n - 1) / 2; j >= row; j--) Console.Write("-");
                    for (int i = 0; i < row; i++) Console.Write("**");
                    for (int j = (n - 1) / 2; j >= row; j--) Console.Write("-");
                    Console.WriteLine();
                }
            }

            else if (n % 2 == 1)
            {
                for (int row = 1; row <= (n + 1) / 2; row++)
                {
                    for (int j = (n - 1) / 2; j >= row; j--) Console.Write("-");
                    Console.Write("*");
                    for (int i = 2; i <= row; i++) Console.Write("**");
                    for (int j = (n - 1) / 2; j >= row; j--) Console.Write("-");
                    Console.WriteLine();
                }
            }

            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }


        }
    }
}
