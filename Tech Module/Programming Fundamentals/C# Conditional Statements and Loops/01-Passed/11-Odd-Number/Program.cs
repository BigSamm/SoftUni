using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                var n = int.Parse(Console.ReadLine());
                n = Math.Abs(n);
                if (n % 2 == 0)
                    Console.WriteLine("Please write an odd number.");
                else if (n % 2 == 1)
                {
                    Console.WriteLine("The number is: {0}", n);
                    break;
                }
            }




        }
    }
}
