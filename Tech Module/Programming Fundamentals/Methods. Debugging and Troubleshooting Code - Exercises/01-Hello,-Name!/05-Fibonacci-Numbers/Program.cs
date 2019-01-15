using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var result = GetFibonacciNumbers(num);
            Console.WriteLine(result);
        }

        static int GetFibonacciNumbers(int num)
        {
            var first = 1;
            var second = 1;
            var sum = 0;

            if (num < 2)
                return 1;
            else
            {
                for (int i = 1; i < num; i++)
                {
                    sum = first + second;
                    first = second;
                    second = sum;
                }
                return sum;
            }
        }
    }
}
