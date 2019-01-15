using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var br = 0;

            for (int i = 1; i <= 100; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
                br++;
                if (br == n)
                    break;
            }

            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
