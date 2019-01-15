using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 2; i <= n; i++)
            {
                bool isItPrime = true;
                for (int h = 2; h <= Math.Sqrt(i); h++)
                {
                    if (i % h == 0)
                    {
                        isItPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isItPrime}");
            }

        }
    }
}
