using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var EvenSum = 0;
            var OddSum = 0;

            for (int i = 0; i < n ; i++)
            {
                if (i % 2 == 0)
                {
                    var even = int.Parse(Console.ReadLine());
                    EvenSum += even;
                }
                else
                {
                    var odd = int.Parse(Console.ReadLine());
                    OddSum += odd;
                }
            }

            if (EvenSum == OddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + EvenSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(EvenSum - OddSum));
            }

            // 11 min
        }
    }
}
