using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool check;
            var firstNum = 0;
            var secondNum = 0;
            var thirdNum = 0;
            int i;
            var sum = 0;

            for (i = 1; i <= n; i++)
            {
                check = false;
                firstNum = i % 10;
                secondNum = (i / 10) % 10;
                thirdNum = i / 100;
                sum = firstNum + secondNum + thirdNum;
                if (sum == 5 || sum == 7 || sum == 11)
                    check = true;
                Console.WriteLine($"{i} -> {check}");
            }
            


        }
    }
}
