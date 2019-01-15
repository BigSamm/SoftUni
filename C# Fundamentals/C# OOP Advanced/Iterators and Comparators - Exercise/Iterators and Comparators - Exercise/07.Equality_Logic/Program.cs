using System;
using System.Collections.Generic;

namespace _06.Strategy_Pattern
{
    class Program
    {
        static void Main()
        {
            var persons1 = new SortedSet<string>();
            var persons2 = new HashSet<string>();

            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var args = Console.ReadLine().Split();
                var name = args[0];
                var age = int.Parse(args[1]);

                var currentPerson = new Person(name, age);
                persons1.Add(currentPerson.ToString());
                persons2.Add(currentPerson.ToString());
            }

            Console.WriteLine(persons1.Count);
            Console.WriteLine(persons2.Count);              
        }
    }
}
