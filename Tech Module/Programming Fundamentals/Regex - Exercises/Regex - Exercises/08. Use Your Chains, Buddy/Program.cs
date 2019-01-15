using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _08.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var firstRegex = @"<p>(.+?)<\/p>";
            var matches = Regex.Matches(input, firstRegex)
                .Cast<Match>()
                .Select(a => a.Groups[1].Value)
                .ToList();

            var cleanedMatches = matches
                .Select(m => Regex.Replace(m, @"[^a-z\d]", " "))
                .Select(m => Regex.Replace(m, @"[ ]+", " "))
                .ToList();
                
            var decodedMathes = DecodeMatches(cleanedMatches);

            var result = string.Empty;
            foreach (var match in decodedMathes)
            {
                result += match;
            }
            Console.WriteLine(result);
        }

        private static List<string> DecodeMatches(List<string> cleanedMatches)
        {
            var decodedMatches = new List<string>();
            foreach (var m in cleanedMatches)
            {
                var result = string.Empty;
                var charArr = m.ToCharArray();
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (charArr[i] >= 'a' && charArr[i] <= 'm')
                        result += (char)(charArr[i] + 13);
                    else if (charArr[i] >= 'n' && charArr[i] <= 'z')
                        result += (char)(charArr[i] - 13);
                    else
                        result += (char)(charArr[i]);
                }
                decodedMatches.Add(result);
            }
            return decodedMatches;
        }
    }
}
