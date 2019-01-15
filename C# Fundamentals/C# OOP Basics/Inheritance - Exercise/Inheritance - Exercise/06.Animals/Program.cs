using System;
using System.Collections.Generic;

class Program
{
    public static List<Animal> animals = new List<Animal>();

    static void Main(string[] args)
    {
        string inputLine;
        while((inputLine = Console.ReadLine()) != "Beast!")
        {
            var animalType = inputLine;
            var animalList = Console.ReadLine().Split();

            TryAddAnimal(animalType, animalList);
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }

    private static void TryAddAnimal(string type, string[] animalList)
    {
        var name = animalList[0];
        var age = int.Parse(animalList[1]);
        var gender = animalList[2];

        try
        {
            Animal animal = new Animal();
            switch (type)
            {
                case "Dog": animal = new Dog(name, age, gender, type); break;
                case "Frog": animal = new Frog(name, age, gender, type); break;
                case "Cat": animal = new Cat(name, age, gender, type); break;
                case "Kittens": animal = new Kitten(name, age, type); break;
                case "Tomcat": animal = new Tomcat(name, age, type); break;
            }
            
            animals.Add(animal);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}