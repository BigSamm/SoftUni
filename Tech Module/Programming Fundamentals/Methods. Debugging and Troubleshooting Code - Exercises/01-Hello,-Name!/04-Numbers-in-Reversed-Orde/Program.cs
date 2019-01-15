using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Numbers_in_Reversed_Orde
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = decimal.Parse(Console.ReadLine());
            var reversedNum = ReverseDecimalNum(num);
            Console.WriteLine(reversedNum);
        }

        static decimal ReverseDecimalNum(decimal num)
        {
           char[] reverseNumArr = num.ToString().ToCharArray();
            Array.Reverse(reverseNumArr);
            num = decimal.Parse(new string(reverseNumArr));
            return num;
        }
    }
}
