using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;
            var sum4 = 0;

            for (int i = 0; i < n; i++)
            {
                var nums = int.Parse(Console.ReadLine());

                if (i == 1 && i == 2) sum1 = sum1 + i[1] + i[2];

            }

            int[] ArrayNums = new int[4] { sum1, sum2, sum3, sum4 };
            Array.Sort(ArrayNums);
            if (sum1 == sum2 && sum2 == sum3 && sum3 == sum4) Console.WriteLine("Yes, value=" + sum1);
            else Console.WriteLine("No, maxdiff={0}", ArrayNums.Max() - ArrayNums.Min());


            //Console.WriteLine("{0} , {1} , {2} , {3}",sum1,sum2,sum3,sum4);
        
        
        }
    }
}
