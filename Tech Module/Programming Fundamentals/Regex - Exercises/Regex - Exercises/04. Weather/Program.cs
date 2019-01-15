using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class Program
    {
        class City
        {
            public string Name { get; set; }
            public double Temperature { get; set; }
            public string WeatherType { get; set; }
        }

        static void Main(string[] args)
        {
            List<City> allCities = new List<City>();
            var regex = @"([A-Z]{2})(\d+.\d+)([A-Za-z]+)\|";

            var allMatches = TakeAllMatches(regex);

            foreach (Match match in allMatches)
            {
                var isContains = false;
                foreach (var c in allCities)
                {
                    if (c.Name == match.Groups[1].Value)
                    {
                        c.Temperature = double.Parse(match.Groups[2].Value);
                        c.WeatherType = match.Groups[3].Value;
                        isContains = true;
                    }
                }

                if(!isContains)
                {
                    City city = new City();
                    city.Name = match.Groups[1].Value;
                    city.Temperature = double.Parse(match.Groups[2].Value);
                    city.WeatherType = match.Groups[3].Value;
                    allCities.Add(city);
                }
            }

            var result = allCities.OrderBy(a => a.Temperature).ToList();

            foreach (var city in result)
            {
                Console.WriteLine($"{city.Name} => {city.Temperature:f2} => {city.WeatherType}");
            }
        }

        private static List<Match> TakeAllMatches(string regex)
        {
            List<Match> allMatches = new List<Match>();
            for (;;)
            {
                var input = Console.ReadLine();
                if (input == "end")
                    return allMatches;

                var currentMatch = Regex.Match(input, regex);
                if(currentMatch.Success)
                    allMatches.Add(currentMatch);
            }
        }
    }
}
