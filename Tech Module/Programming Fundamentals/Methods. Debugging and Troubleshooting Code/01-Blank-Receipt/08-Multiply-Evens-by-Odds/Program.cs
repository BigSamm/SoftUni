using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var result = GetMultipleOfEvensAndOdds(num);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvensAndOdds(int num)
        {
            if (num < 0) num = Math.Abs(num);
            int sumEvens = GetSumOfEvenDigits(num);
            int sumOdds = GetSumOfTheOddDigits(num);
            return sumEvens * sumOdds;
        }

        static int GetSumOfTheOddDigits(int num, int sum = 0)
        {
            while(num > 0)
            {
                if ((num % 10) % 2 == 1)
                    sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        static int GetSumOfEvenDigits(int num, int sum = 0)
        {
            while (num > 0)
            {
                if ((num % 10) % 2 == 0)
                    sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
