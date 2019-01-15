using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            var emial = Console.ReadLine();
            var regex = @"(.*?)@(.*)";
            var match = Regex.Match(emial, regex);

            var firstPart = match.Groups[1].Value;
            var secondPart = match.Groups[2].Value;

            var firstPartSum = TakeSum(firstPart);
            var secondPartSum = TakeSum(secondPart);

            if(secondPartSum <= firstPartSum)
                Console.WriteLine("Call her!");
            else
                Console.WriteLine("She is not the one.");
        }

        private static int TakeSum(string part)
        {
            var charArr = part.ToCharArray();
            var sum = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                sum += charArr[i];
            }
            return sum;
        }
    }
}
