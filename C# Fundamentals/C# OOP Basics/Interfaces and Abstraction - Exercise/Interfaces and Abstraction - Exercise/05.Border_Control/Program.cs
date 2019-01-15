using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var citizens = new List<ICitizen>();

        string inputLine;
        while((inputLine = Console.ReadLine()) != "End")
        {
            var inputList = inputLine.Split();
            if (inputList.Length == 3)
                AddPerson(inputList, citizens);
            else if (inputList.Length == 2)
                AddRobot(inputList, citizens);
        }

        var fakeIdsLastDigits = Console.ReadLine();
        var realCitizens = citizens.Where(c => c.Id.EndsWith(fakeIdsLastDigits));

        foreach (var citizen in realCitizens)
        {
            Console.WriteLine(citizen);
        }
    }

    private static void AddRobot(string[] inputList, List<ICitizen> citizens)
    {
        var model = inputList[0];
        var id = inputList[1];

        ICitizen robot = new Robot(model, id);
        citizens.Add(robot);
    }

    private static void AddPerson(string[] inputList, List<ICitizen> citizens)
    {
        var name = inputList[0];
        var age = int.Parse(inputList[1]);
        var id = inputList[2];

        ICitizen person = new Person(name, age, id);
        citizens.Add(person);
    }
}