using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                var input = Console.ReadLine();
                if (input == "END") break;
                
                List<string> matchesInCurrentRow = TakeAllMatchesInCurrentRow(input);

                var regex = @"[ ]+";
                var revampedMatches = new List<string>();
                foreach (var m in matchesInCurrentRow)
                {
                    revampedMatches.Add(Regex.Replace(m, regex, " "));
                }

                var result = new Dictionary<string, string>();
                var pattern = @"(.+)=(.+)";
                foreach (var match in revampedMatches)
                {
                    var m = Regex.Match(match, pattern);
                    var key = m.Groups[1].Value.Trim();
                    var value = m.Groups[2].Value.Trim();

                    if (result.ContainsKey(key))
                        result[key] += $", {value}";
                    else
                        result[key] = value;
                }


                foreach (var r in result)
                {
                    Console.Write($"{r.Key}=[{r.Value}]");
                }
                Console.WriteLine();
            }
        }

        private static List<string> TakeAllMatchesInCurrentRow(string input)
        {
            var revampedInput = input.Replace("%20", " ").Replace("+", " ");

            var matches = new List<string>();
            var regex = @"(.+)=(.+)";
            var rowList = revampedInput
                .Split(new char[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            foreach (var r in rowList)
            {
                var m = Regex.Match(r, regex);
                if (m.Success)
                    matches.Add(m.ToString());
            }

            return matches;
        }



    }
}
