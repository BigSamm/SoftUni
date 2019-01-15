using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            var num1 = start;
            var num2 = start;
            var br = 0;
            var stop = false;

            for (int i = start; i >= end; i--)
            {

                for (int j = start; j >= end; j--)
                {
                    br++;
                    if (num1 + num2 == magicNumber)
                    {
                        break;
                    }
                    //Console.WriteLine("{0} - {1}", num1, num2);
                    if (num2 == end) break;
                    num2--;
                }
                if (num1 + num2 == magicNumber)
                {
                    stop = true;
                    break;
                }
                num2 = start;
                if (num1 == end) break;
                num1--;

            }

            if (stop) Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", br, num1, num2, magicNumber);
            else Console.WriteLine("{0} combinations - neither equals {1}", br, magicNumber);
        }

    }

}