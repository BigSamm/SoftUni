using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            bool isPrime = GetPrimeStatus(num);
            Console.WriteLine(isPrime);
        }

        static bool GetPrimeStatus(long num)
        {
            if (num < 2)
                return false;
            if (num == 2)
                return true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}

