using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.Regeh
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regex = @"\[[^[\s]+<(\d+)REGEH(\d+)>[^]\s]+]";

            var matches = Regex.Matches(input, regex).Cast<Match>().ToList();
            var indexes = new List<int>();

            foreach (var match in matches)
            {
                indexes.Add(int.Parse(match.Groups[1].ToString()));
                indexes.Add(int.Parse(match.Groups[2].ToString()));
            }

            var result = new StringBuilder();
            var currentIndex = 0;

            foreach (var index in indexes)
            {
                currentIndex += index;

                if (currentIndex >= input.Length)
                    currentIndex -= input.Length - 1;

                result.Append(input[currentIndex]);
            }

            Console.WriteLine(result);
        }
    }
}