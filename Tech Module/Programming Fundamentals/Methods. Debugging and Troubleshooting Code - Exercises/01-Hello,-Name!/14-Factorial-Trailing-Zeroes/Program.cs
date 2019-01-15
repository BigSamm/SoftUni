using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14_Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            var trailingZeroes = GetFactorialTrailingZeroes(factorial);
            Console.WriteLine(trailingZeroes);
        }

        static int GetFactorialTrailingZeroes(BigInteger factorial)
        {
            var count = 0;
            while (factorial % 10 == 0)
            {
                count++;
                factorial /= 10;
            }
            return count;
        }
    }
}
