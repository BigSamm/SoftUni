using System;
using System.Collections.Generic;

namespace _06.Strategy_Pattern
{
    class Program
    {
        static void Main()
        {
            var persons1 = new SortedSet<Person>(new PersonNameComparator());
            var persons2 = new SortedSet<Person>(new PersonAgeComparator());

            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var args = Console.ReadLine().Split();
                var name = args[0];
                var age = int.Parse(args[1]);

                var currentPerson = new Person(name, age);
                persons1.Add(currentPerson);
                persons2.Add(currentPerson);
            }

            foreach (var person in persons1)
            {
                Console.WriteLine(person);
            }
            foreach (var person in persons2)
            {
                Console.WriteLine(person);
            }
        }
    }
}
