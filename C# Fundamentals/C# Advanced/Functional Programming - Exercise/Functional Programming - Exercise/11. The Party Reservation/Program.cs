using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.The_Party_Reservation
{
    class Program
    {
        public static List<string> people = new List<string>();

        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var filters = CreateFiltersDictionary();

            string command;
            while((command = Console.ReadLine()) != "Print")
            {
                DoCommand(command, filters);
            }

            people = ApplyFilters(filters, people);

            Console.WriteLine(String.Join(" ", people));
        }

        private static List<string> ApplyFilters(Dictionary<string, List<string>> filters, List<string> people)
        {
            foreach (var item in filters)
            {
                item.Value.Distinct();
            }

            foreach (var param in filters["Starts with"])
            {
                people = people.Where(p => !p.StartsWith(param)).ToList();
            }

            foreach (var param in filters["Ends with"])
            {
                people = people.Where(p => !p.EndsWith(param)).ToList();
            }

            foreach (var param in filters["Length"])
            {
                people = people.Where(p => p.Length != int.Parse(param)).ToList();
            }

            foreach (var param in filters["Contains"])
            {
                people = people.Where(p => !p.Contains(param)).ToList();
            }

            return people;
        }

        private static void DoCommand(string command, Dictionary<string, List<string>> filters)
        {
            var commandList = command.Split(';').ToList();
            var filterType = commandList[1];
            var filterParameter = commandList[2];

            if (commandList[0] == "Add filter")
            {
                switch (filterType)
                {
                    case "Starts with":
                        filters["Starts with"].Add(filterParameter);
                        break;
                    case "Ends with":
                        filters["Ends with"].Add(filterParameter);
                        break;
                    case "Length":
                        filters["Length"].Add(filterParameter);
                        break;
                    case "Contains":
                        filters["Contains"].Add(filterParameter);
                        break;
                }
            }
            else if (commandList[0] == "Remove filter")
            {
                switch (filterType)
                {
                    case "Starts with":
                        filters["Starts with"].Remove(filterParameter);
                        break;
                    case "Ends with":
                        filters["Ends with"].Remove(filterParameter);
                        break;
                    case "Length":
                        filters["Length"].Remove(filterParameter);
                        break;
                    case "Contains":
                        filters["Contains"].Remove(filterParameter);
                        break;
                }
            }
        }

        private static Dictionary<string, List<string>> CreateFiltersDictionary()
        {
            var filters = new Dictionary<string, List<string>>();
            filters["Starts with"] = new List<string>();
            filters["Ends with"] = new List<string>();
            filters["Length"] = new List<string>();
            filters["Contains"] = new List<string>();

            return filters;
        }
    }
}