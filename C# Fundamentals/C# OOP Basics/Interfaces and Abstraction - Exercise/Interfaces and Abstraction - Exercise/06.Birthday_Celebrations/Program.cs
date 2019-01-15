
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var animals = new List<IAnimal>();

        string inputLine;
        while((inputLine = Console.ReadLine()) != "End")
        {
            var inputList = inputLine.Split();
            if (inputList.Length == 5)
                AddCitizen(inputList, animals);
            else if (inputList.Length == 3 && inputList[0] == "Pet")
                AddPet(inputList, animals);
        }

        var birthdateYear = Console.ReadLine();
        var validAnimals = animals.Where(a => a.Birthdate.EndsWith(birthdateYear)).ToList();
        foreach (var animal in validAnimals)
        {
            Console.WriteLine(animal);
        }
    }

    private static void AddPet(string[] inputList, List<IAnimal> animals)
    {
        var name = inputList[1];
        var birthdate = inputList[2];

        IAnimal pet = new Pet(name, birthdate);
        animals.Add(pet);
    }

    private static void AddCitizen(string[] inputList, List<IAnimal> animals)
    {
        var name = inputList[1];
        var age = int.Parse(inputList[2]);
        var id = inputList[3];
        var birthdate = inputList[4];

        IAnimal citizen = new Citizen(name, age, id, birthdate);
        animals.Add(citizen);
    }
}
