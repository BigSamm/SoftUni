using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03_English_Name_of_LastDigit
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            string lastDigitInString = MakeLastDigitToString(num);
            Console.WriteLine(lastDigitInString);
        }

        static string MakeLastDigitToString(long num)
        {
            string numString = num.ToString();
            int digit = int.Parse(numString.Substring(numString.Length - 1));

            string[] digitsNames = new string[]
                {
                    "zero",
                    "one",
                    "two",
                    "tree",
                    "four",
                    "five",
                    "six",
                    "seven",
                    "eight",
                    "nine"
                };
            return digitsNames[digit];
        }
    
    }
}
