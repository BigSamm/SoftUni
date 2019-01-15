using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(^|(?<=\s))-?([1-9]\d*)(\.\d*)?($|(?=\s))";
            var input = Console.ReadLine();
            var allNums = Regex.Matches(input, regex);

            foreach (Match num in allNums)
            {
                Console.Write(num.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
