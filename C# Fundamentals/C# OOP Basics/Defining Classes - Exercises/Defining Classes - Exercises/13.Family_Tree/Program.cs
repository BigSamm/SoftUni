using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Person neededPerson = TakeFirstPerson();

        var allPersons = new List<Person>();
        var commands = new List<string>();

        string inputLine;
        while ((inputLine = Console.ReadLine()) != "End")
        {
            if (inputLine.Contains("-"))
            {
                commands.Add(inputLine);
            }
            else
            {
                Person currentPerson = TakePerson(inputLine);
                allPersons.Add(currentPerson);
            
                if (currentPerson.Name == neededPerson.Name || currentPerson.Birthday == neededPerson.Birthday)
                    neededPerson = currentPerson;
            }
        }

        foreach (var command in commands)
        {
            DoCommand(command, neededPerson, allPersons);
        }

        Console.WriteLine(neededPerson);
    }

    private static void DoCommand(string command, Person neededPerson, List<Person> allPersons)
    {
        var commandList = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
        var firstPerson = allPersons.Find(p => p.Name == commandList[0] || p.Birthday == commandList[0]);
        var secondPerson = allPersons.Find(p => p.Name == commandList[1] || p.Birthday == commandList[1]);

        if (firstPerson.Name == neededPerson.Name)
            neededPerson.Children.Add(secondPerson);
        else if (secondPerson.Name == neededPerson.Name)
            neededPerson.Parents.Add(firstPerson);
    }

    private static Person TakePerson(string inputLine)
    {
        var inputLineList = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var firstName = inputLineList[0];
        var lastName = inputLineList[1];
        var birthday = inputLineList[2];

        var person = new Person(firstName, lastName, birthday);
        return person;
    }

    private static Person TakeFirstPerson()
    {
        var personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        Person person;
        if (personInfo.Length == 1)
        {
            var birthday = personInfo[0];
            person = new Person(birthday);
        }
        else
        {
            var firstName = personInfo[0];
            var secondName = personInfo[1];
            person = new Person(firstName, secondName);
        }

        return person;
    }
}
