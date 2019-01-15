using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Crypto_Blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = TakeInput();

            var pattern = @"((?<scope>{)|\[)[^{\[\]}]*?(?<nums>\d{3,})[^{\[\]}]*(?(scope)}|])";
            var allMatches = Regex.Matches(input, pattern).Cast<Match>().ToList();

            var validMatches = new List<Match>();
            foreach (var match in allMatches)
            {
                var nums = match.Groups["nums"];
                if (nums.Length % 3 == 0)
                    validMatches.Add(match);
            }

            StringBuilder result = new StringBuilder();
            foreach (var match in validMatches)
            {
                Queue<char> queueNums = new Queue<char>(match.Groups["nums"].ToString().ToCharArray());
                var allNums = new List<int>();

                while (queueNums.Count != 0)
                {
                    int num = int.Parse(queueNums.Dequeue().ToString() + queueNums.Dequeue().ToString() + queueNums.Dequeue().ToString());
                    allNums.Add(num);
                }

                var matchLength = match.Length;
                foreach (var num in allNums)
                {
                    result.Append((char)(num - matchLength));
                }
            }

            Console.WriteLine(result);
        }

        private static string TakeInput()
        {
            var lines = int.Parse(Console.ReadLine());

            var input = new StringBuilder();
            for (int i = 0; i < lines; i++)
            {
                var inputLine = Console.ReadLine();
                input.Append(inputLine);
            }

            return input.ToString();
        }
    }
}