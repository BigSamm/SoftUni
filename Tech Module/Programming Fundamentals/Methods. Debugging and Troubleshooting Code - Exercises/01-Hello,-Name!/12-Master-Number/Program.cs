using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                bool palindrome = IsSymmetric(i);
                bool divisibleBy7 = IsDivisibleBy7(i);
                bool evenDigit = IsThereEvenDigit(i);
                if(palindrome && divisibleBy7 && evenDigit)
                    Console.WriteLine(i);
            }



        }

        static bool IsThereEvenDigit(int num)
        {
            while(num > 0)
            {
                if ((num % 10) % 2 == 0)
                    return true;
                num /= 10;
            }
            return false;
        }

        static bool IsDivisibleBy7(int num)
        {
            sbyte sum = 0;
            while (num > 0)
            {
                sum += (sbyte)(num % 10);
                num /= 10;
            }
            if (sum % 7 == 0)
                return true;
            return false;
        }

        static bool IsSymmetric(int num)
        {
            string numToString = num.ToString();
            string reversedNum = string.Empty;
            for (sbyte i = (sbyte)(numToString.Length - 1); i >= 0; i--)
            {
                reversedNum += numToString[i];
            }
            uint result = uint.Parse(reversedNum);
            if (result == num)
                return true;
            return false;
        }
    }
}
