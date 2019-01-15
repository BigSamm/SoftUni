using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Treasure_Map
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            
            var validMatches = new List<Match>();

            for (int i = 0; i < lines; i++)
            {
                var unlockedMatches = TakeUnlockedMatches();

                validMatches.Add(TakeValidMatches(unlockedMatches));
            }

            foreach (var match in validMatches)
            {
                var adressName = match.Groups[1];
                var streetNum = match.Groups[2];
                var password = match.Groups[3];

                Console.WriteLine($"Go to str. {adressName} {streetNum}. Secret pass: {password}.");
            }
        }

        private static Match TakeValidMatches(List<Match> unlockedMatches)
        {
            var validMatches = new List<Match>();
            var pattern = @".*?(?<![a-zA-Z0-9])([a-zA-Z]{4})(?![a-zA-Z\d]).*(?<![\d])(\d{3})-(\d{6}|\d{4})(?![\d]).*";

            foreach (var currentMatch in unlockedMatches)
            {
                var validMatch = Regex.Match(currentMatch.ToString(), pattern);
                if (validMatch.Success)
                {
                    validMatches.Add(validMatch);
                }
            }

            var correctMatch = validMatches[validMatches.Count / 2];

            return correctMatch;
        }

        private static List<Match> TakeUnlockedMatches()
        {
            List<Match> matches = new List<Match>();
            var pattern = @"#[^#!]{12,}!|![^#!]{12,}#";
            
            var inputLine = Console.ReadLine();

            var currentMatches = Regex.Matches(inputLine, pattern)
                .Cast<Match>()
                .ToList();

            matches.AddRange(currentMatches);


            return matches;
        }
    }
}
