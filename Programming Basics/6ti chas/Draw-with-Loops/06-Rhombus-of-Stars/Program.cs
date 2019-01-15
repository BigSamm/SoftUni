using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ' , n - row));
                Console.Write("*");
                for (int i = 1; i <= row - 1; i++) Console.Write(" *");
                Console.WriteLine();
            }

            for (int row = 1; row <= n - 1; row++)
            {
                Console.Write(new string(' ', row));
                Console.Write("*");
                for (int i = n - 2; i >= row; i--) Console.Write(" *");
                Console.WriteLine();
                
            }


        }
    }
}
