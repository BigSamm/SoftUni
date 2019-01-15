using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Inferno_III
{
    class Program
    {
        static void Main(string[] args)
        {
            var gems = Console.ReadLine().Split().Select(int.Parse).ToList();
            Dictionary<string, List<int>> allCommands = CreateCommandsDictionary();

            string command;
            while ((command = Console.ReadLine()) != "Forge")
            {
                AddCommands(command, allCommands);
            }

            List<int> indexesForRemove = ApplyCommands(allCommands, gems);

            gems = gems.Where(gem => !indexesForRemove.Contains(gems.IndexOf(gem))).ToList();

            Console.WriteLine(String.Join(" ", gems));
        }

        private static List<int> ApplyCommands(Dictionary<string, List<int>> allCommands, List<int> gems)
        {
            var indexesForRemove = new List<int>();

            indexesForRemove.AddRange(SumLeft(allCommands["Sum Left"], gems));
            indexesForRemove.AddRange(SumRight(allCommands["Sum Right"], gems));
            indexesForRemove.AddRange(SumLeftRight(allCommands["Sum Left Right"], gems));

            return indexesForRemove;
        }

        private static List<int> SumLeftRight(List<int> list, List<int> gems)
        {
            var indexesForRemove = new List<int>();

            foreach (var num in list)
            {
                for (int index = 0; index < gems.Count; index++)
                {
                    var leftGem = index > 0 ? gems[index - 1] : 0;
                    var rightGem = index < gems.Count - 1 ? gems[index + 1] : 0;
                    if (leftGem + gems[index] + rightGem == num)
                        indexesForRemove.Add(index);
                }
            }

            return indexesForRemove;
        }

        private static List<int> SumRight(List<int> list, List<int> gems)
        {
            var indexesForRemove = new List<int>();

            foreach (var num in list)
            {
                for (int index = 0; index < gems.Count; index++)
                {
                    var rightGem = index < gems.Count - 1 ? gems[index + 1] : 0;
                    if (gems[index] + rightGem == num)
                        indexesForRemove.Add(index);
                }
            }

            return indexesForRemove;
        }

        private static List<int> SumLeft(List<int> list, List<int> gems)
        {
            var indexesForRemove = new List<int>();

            foreach (var num in list)
            {
                for (int index = 0; index < gems.Count; index++)
                {
                    var leftGem = index > 0 ? gems[index - 1] : 0;
                    if (leftGem + gems[index] == num)
                        indexesForRemove.Add(index);
                }
            }

            return indexesForRemove;
        }

        private static void AddCommands(string command, Dictionary<string, List<int>> allCommands)
        {
            var commandList = command.Split(';').ToList();
            var currentCommand = commandList[0];
            var filterType = commandList[1];
            var filterParam = int.Parse(commandList[2]);

            if (currentCommand == "Exclude")
            {
                if (!allCommands[filterType].Contains(filterParam))
                    allCommands[filterType].Add(filterParam);
            }
            else if (currentCommand == "Reverse")
            {
                if (allCommands[filterType].Contains(filterParam))
                {
                    allCommands[filterType].Remove(filterParam);
                }
            }
        }

        private static Dictionary<string, List<int>> CreateCommandsDictionary()
        {
            var allCommands = new Dictionary<string, List<int>>();
            allCommands["Sum Left"] = new List<int>();
            allCommands["Sum Right"] = new List<int>();
            allCommands["Sum Left Right"] = new List<int>();

            return allCommands;
        }
    }
}