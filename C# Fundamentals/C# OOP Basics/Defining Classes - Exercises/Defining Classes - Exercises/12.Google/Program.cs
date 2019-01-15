using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var persons = new List<Person>();

        string command;
        while((command = Console.ReadLine()) != "End")
        {
            var commandList = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var personName = commandList[0];

            Person person = new Person(personName);
            if (persons.Any(p => p.Name == personName))
                person = persons.Find(p => p.Name == personName);

            var type = commandList[1];
            var firstArg = commandList[2];
            var secondArg = commandList[3];
            switch (type)
            {
                case "company": AddCompany(person, firstArg, secondArg, commandList[4]); break;
                case "pokemon": AddPokemon(person, firstArg, secondArg); break;
                case "parents": AddParent(person, firstArg, secondArg); break;
                case "children": AddChild(person, firstArg, secondArg); break;
                case "car": AddCar(person, firstArg, secondArg); break;
            }

            persons.Add(person);
        }

        PrintPerson(persons);
    }

    private static void PrintPerson(List<Person> persons)
    {
        string name = Console.ReadLine();
        var person = persons.Find(p => p.Name == name);

        Console.WriteLine(person);
    }

    private static void AddCar(Person person, string carModel, string carSpeedStr)
    {
        var car = new Car(carModel, carSpeedStr);
        person.Car = car;
    }

    private static void AddChild(Person person, string childName, string childBirthday)
    {
        var child = new Child(childName, childBirthday);
        person.Children.Add(child);
    }

    private static void AddParent(Person person, string parentName, string parentBirthday)
    {
        var parent = new Parent(parentName, parentBirthday);
        person.Parents.Add(parent);
    }

    private static void AddPokemon(Person person, string pokName, string pokType)
    {
        var pokemon = new Pokemon(pokName, pokType);
        person.Pokemons.Add(pokemon);
    }

    private static void AddCompany(Person person, string compName, string compDepartment, string salaryStr)
    {
        var company = new Company(compName, compDepartment, salaryStr);
        person.Company = company;
    }
}
