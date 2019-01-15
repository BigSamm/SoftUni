using System;
using System.Collections.Generic;

namespace _05.Comparing_Objects
{
    class Program
    {
        static void Main()
        {
            var persons = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var args = input.Split();
                var name = args[0];
                var age = int.Parse(args[1]);
                var town = args[2];

                var currentPerson = new Person(name, age, town);
                persons.Add(currentPerson);
            }

            var index = int.Parse(Console.ReadLine());
            var person = persons[index - 1];
            var compareCount = 0;
            for (int i = 0; i < persons.Count; i++)
            {
                if (person.CompareTo(persons[i]) == 0)
                    compareCount++;
            }

            if (compareCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.Write(compareCount + " ");
                Console.Write(persons.Count - compareCount + " ");
                Console.WriteLine(persons.Count);
            }
        }
    }
}
