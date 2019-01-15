using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            var firstNum = start;
            var secondNum = start;
            var br = 0;
            int i = 0;
            int j = 0;

            for (i = 1; i <= end - start + 1; i++)
            {
                for (j = 1; j <= end - start + 1; j++)
                {
                    Console.Write("<{0}-{1}>", firstNum, secondNum);
                    secondNum++;
                    br++;
                    if (br == max) return;
                }
                secondNum = start;
                firstNum++;

            }




        }
    }
}
