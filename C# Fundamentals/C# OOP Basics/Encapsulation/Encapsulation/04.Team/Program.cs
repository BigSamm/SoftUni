using System;
using System.Collections.Generic;
using System.Linq;

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

            var person = new Person(firstName, lastName, age, salary);
            persons.Add(person);
        }

        var team = new Team("MyTeam");
        foreach (var player in persons)
        {
            team.AddPlayer(player);
        }

        Console.WriteLine(team);
    }
}
