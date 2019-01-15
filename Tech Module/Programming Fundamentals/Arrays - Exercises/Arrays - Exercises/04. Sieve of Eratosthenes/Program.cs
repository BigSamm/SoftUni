using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var nums = new bool [n + 1];
            for (long i = 0; i <= n; i++)
            {
                nums[i] = true;
            }

            for (long i = 0; i <= n; i++)
            {
                nums[i] = FindPrimeNums(i);
                if (nums[i])
                    Console.Write(i + " ");
            }
            
        }

        static bool FindPrimeNums(long i)
        {
            bool isPrime = true;
            if (i < 2)
                isPrime = false;
            else if (i == 2 || i == 3 || i == 5 || i == 7)
                isPrime = true;
            else if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                isPrime = false;
            return isPrime;
        }

        
    }
}
