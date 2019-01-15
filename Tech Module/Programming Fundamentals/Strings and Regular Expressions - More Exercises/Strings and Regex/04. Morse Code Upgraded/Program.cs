using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Morse_Code_Upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regex = @"[01]+";
            var matches = Regex.Matches(input, regex)
                .Cast<Match>()
                .Select(m => m.Value)
                .ToList();

            var result = string.Empty;
            foreach (var match in matches)
            {
                var charArr = match.ToCharArray();
                var oneCounter = 0;
                var zeroCounter = 0;
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (charArr[i] == '0') zeroCounter++;
                    else if (charArr[i] == '1') oneCounter++;
                }
                var sum = zeroCounter * 3 + oneCounter * 5;


            }



        }
    }
}
