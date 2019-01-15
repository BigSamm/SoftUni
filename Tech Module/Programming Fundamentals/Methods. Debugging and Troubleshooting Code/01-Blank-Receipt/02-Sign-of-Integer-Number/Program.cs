using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            PrintSign(num);
        }

        static void PrintSign(int num)
        {
            if (num < 0)
                Console.WriteLine($"The number {num} is negative.");
            else if(num > 0)
                Console.WriteLine($"The number {num} is positive.");
            else
                Console.WriteLine($"The number 0 is zero.");
        }
    }
}
