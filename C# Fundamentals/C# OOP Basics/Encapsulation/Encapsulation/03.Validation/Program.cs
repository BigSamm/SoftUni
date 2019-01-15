using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var persons = new List<Person>();

        var lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            var inputList = Console.ReadLine().Split();
            var firstName = inputList[0];
            var lastName = inputList[1];
            var age = int.Parse(inputList[2]);
            var salary = decimal.Parse(inputList[3]);

            Person person = new Person();
            try
            {
                person = new Person(firstName, lastName, age, salary);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (person.FirstName != null)
                persons.Add(person);
        }

        var bonus = decimal.Parse(Console.ReadLine());
        persons.ForEach(p => p.IncreaseSalary(bonus));
        persons.ForEach(p => Console.WriteLine(p.ToString()));
    }
}
