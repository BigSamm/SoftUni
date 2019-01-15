using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Order_by_Age
{
    class Program
    {
        static void Main()
        {
            var people = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] args = input.Split();
                string name = args[0];
                string id = args[1];
                int age = int.Parse(args[2]);

                Person person = new Person(name, id, age);
                people.Add(person);
            }

            IEnumerable<Person> orderedPeople = people.OrderBy(p => p.Age);
            foreach (var person in orderedPeople)
            {
                Console.WriteLine(person);
            }
        }
    }

    public class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }

        public string Name { get; }

        public string ID { get; }

        public int Age { get; private set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}
