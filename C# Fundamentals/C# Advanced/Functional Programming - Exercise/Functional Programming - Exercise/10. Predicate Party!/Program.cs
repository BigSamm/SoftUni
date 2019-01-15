using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Predicate_Party_
{
    class Program
    {
        public static List<string> people = new List<string>();

        static void Main(string[] args)
        {
            people = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;
            while ((command = Console.ReadLine()) != "Party!")
            {
                var commandList = command.Split().ToList();
                var type = commandList[0];
                var criterion = commandList[1];
                var numOrStr = commandList[2];

                Func<string, string, List<string>> remove = Remove;
                Func<string, string, List<string>> @double = DoubleCurrent;

                switch (type)
                {
                    case "Remove": remove(criterion, numOrStr); break;
                    case "Double": @double(criterion, numOrStr); break;
                }
            }

            if (people.Count == 0)
                Console.WriteLine("Nobody is going to the party!");
            else
                Console.WriteLine($"{String.Join(", ", people)} are going to the party!");
        }

        private static List<string> DoubleCurrent(string criterion, string numOrStr)
        {
            switch (criterion)
            {
                case "Length":
                    var length = int.Parse(numOrStr);
                    var peopleToAdd = people.Where(p => p.Length == length).ToList();
                    peopleToAdd.ForEach(p => people.Insert(people.IndexOf(p), p));
                    break;
                case "StartsWith":
                    var str = numOrStr;
                    peopleToAdd = people.Where(p => p.StartsWith(str)).ToList();
                    peopleToAdd.ForEach(p => people.Insert(people.IndexOf(p), p));
                    break;
                case "EndsWith":
                    str = numOrStr;
                    peopleToAdd = people.Where(p => p.EndsWith(str)).ToList();
                    peopleToAdd.ForEach(p => people.Insert(people.IndexOf(p), p));
                    break;
            }

            return people;
        }

        private static List<string> Remove(string criterion, string numOrStr)
        {
            switch (criterion)
            {
                case "Length":
                    var length = int.Parse(numOrStr);
                    people = people.Where(p => p.Length != length).ToList();
                    break;
                case "StartsWith":
                    var str = numOrStr;
                    people = people.Where(p => !p.StartsWith(str)).ToList();
                    break;
                case "EndsWith":
                    str = numOrStr;
                    people = people.Where(p => !p.EndsWith(str)).ToList();
                    break;
            }

            return people;
        }
    }
}