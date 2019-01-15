using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Hit_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetInfoIndex = int.Parse(Console.ReadLine());

            var people = new Dictionary<string, Dictionary<string, string>>();

            string inputLine;
            while((inputLine = Console.ReadLine()) != "end transmissions")
            {
                AddPeople(inputLine, people);
            }

            var inputLineList = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var name = inputLineList[1];

            Console.WriteLine($"Info on {name}:");
            var infoIndex = 0;

            people[name] = people[name].OrderBy(p => p.Key).ToDictionary(p => p.Key, p => p.Value);
            foreach (var info in people[name])
            {
                Console.WriteLine($"---{info.Key}: {info.Value}");

                infoIndex += info.Key.Length + info.Value.Length;
            }

            Console.WriteLine($"Info index: {infoIndex}");

            if (infoIndex >= targetInfoIndex)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                var needed = targetInfoIndex - infoIndex;
                Console.WriteLine($"Need {needed} more info.");
            }
        }

        private static void AddPeople(string inputLine, Dictionary<string, Dictionary<string, string>> people)
        {
            string[] inputLineArr = inputLine.Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            var name = inputLineArr[0];

            for (int index = 1; index < inputLineArr.Length; index++)
            {
                var current = inputLineArr[index];
                string[] keyValuePair = current.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                var key = keyValuePair[0];
                var value = keyValuePair[1];

                if (people.ContainsKey(name))
                {
                    var currentPeople = people[name];
                    currentPeople[key] = value;
                }
                else
                {
                    people[name] = new Dictionary<string, string>();
                    var currentPeople = people[name];
                    currentPeople[key] = value;
                }
            }
        }
    }
}