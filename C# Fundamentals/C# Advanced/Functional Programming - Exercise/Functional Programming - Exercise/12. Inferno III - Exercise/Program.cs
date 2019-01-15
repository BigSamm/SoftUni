using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Inferno_III___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var gems = Console.ReadLine().Split().Select(int.Parse).ToList();

            var filters = new Dictionary<string, Func<List<int>, List<int>>>();

            string command;
            while((command = Console.ReadLine()) != "Forge")
            {
                ParseCommand(command, filters);
            }

            List<int> filtered = GetFiltered(gems, filters);

            gems = gems.Where(gem => !filtered.Contains(gem)).ToList();

            var result = String.Join(" ", gems);
            Console.WriteLine(result);
        }

        private static List<int> GetFiltered(List<int> gems, Dictionary<string, Func<List<int>, List<int>>> filters)
        {
            var filtered = new List<int>();

            foreach (var pair in filters)
            {
                var filter = pair.Value;

                filtered.AddRange(filter(gems));
            }

            return filtered;
        }

        private static void ParseCommand(string commandInput, Dictionary<string, Func<List<int>, List<int>>> filters)
        {
            string[] tokens = commandInput.Split(';');
            var command = tokens[0];
            var filterType = tokens[1];
            var parameter = int.Parse(tokens[2]);
            var dictKey = $"{filterType} {parameter}";

            if (command == "Exclude")
            {
                filters[dictKey] = CreateFunction(filterType, parameter);
            }
            else if (command == "Reverse")
            {
                filters.Remove(dictKey);
            }
        }

        private static Func<List<int>, List<int>> CreateFunction(string filterType, int parameter)
        {
            switch (filterType)
            {
                case "Sum Left":
                    return gems => gems.Where(gem =>
                    {
                        var index = gems.IndexOf(gem);
                        var leftGem = index > 0 ? gems[index - 1] : 0;
                        return gem + leftGem == parameter;
                    }).ToList();
                case "Sum Right":
                    return gems => gems.Where(gem =>
                    {
                        var index = gems.IndexOf(gem);
                        var rightGem = index < gems.Count - 1 ? gems[index + 1] : 0;
                        return gem + rightGem == parameter;
                    }).ToList();
                case "Sum Left Right":
                    return gems => gems.Where(gem =>
                    {
                        var index = gems.IndexOf(gem);
                        var leftGem = index > 0 ? gems[index - 1] : 0;
                        var rightGem = index < gems.Count - 1 ? gems[index + 1] : 0;
                        return leftGem + gem + rightGem == parameter;
                    }).ToList();
                default:
                    throw new ArgumentException();
            }
        }
    }
}