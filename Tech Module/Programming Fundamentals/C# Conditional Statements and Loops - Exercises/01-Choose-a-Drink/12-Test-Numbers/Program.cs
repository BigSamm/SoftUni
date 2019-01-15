using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());
            var sum = 0;
            var br = 0;
            var check = false;

            for (int i = n; i >= 1; i--)
            {
                for (int h = 1; h <= m; h++)
                {
                    //Console.WriteLine(i + "  " + h);
                    sum += 3 * (h * i);
                    br++;
                    if(sum >= maxSum)
                    {
                        check = true;
                        break;
                    }
                }
                if (check) break;
            }

            if(check)
            {
                Console.WriteLine($"{br} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{br} combinations");
                Console.WriteLine($"Sum: {sum}");
            }


        }
    }
}
