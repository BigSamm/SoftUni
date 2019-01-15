using System;
using System.Collections.Generic;

class Program
{
    public static List<Animal> animals = new List<Animal>();

    static void Main(string[] args)
    {
        string inputLine;
        while ((inputLine = Console.ReadLine()) != "End")
        {
            var animalList = inputLine.Split();
            Food food = ParseFood();
            AddAnimal(animalList, food);
        }

        animals.ForEach(a => a.CalculateWeight());

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }

    private static Food ParseFood()
    {
        var foodList = Console.ReadLine().Split();

        var type = foodList[0];
        var quantity = int.Parse(foodList[1]);

        switch (type)
        {
            case "Vegetable":
                Food food = new Vegetable(quantity);
                return food;
            case "Fruit":
                food = new Fruit(quantity);
                return food;
            case "Meat":
                food = new Meat(quantity);
                return food;
            case "Seeds":
                food = new Seeds(quantity);
                return food;
        }

        throw new ArgumentException();
    }

    private static void AddAnimal(string[] animalList, Food food)
    {
        var animalType = animalList[0];

        switch (animalType)
        {
            case "Owl": FeedOwl(animalList, food); break;
            case "Hen": FeedHen(animalList, food); break;
            case "Mouse": FeedMouse(animalList, food); break;
            case "Dog": FeedDog(animalList, food); break;
            case "Cat": FeedCat(animalList, food); break;
            case "Tiger": FeedTiger(animalList, food); break;
        }
    }

    private static void FeedTiger(string[] animalList, Food food)
    {
        var animalType = animalList[0];
        var animalName = animalList[1];
        var animalWeight = double.Parse(animalList[2]);
        var animalLivingRegion = animalList[3];
        var animalBreed = animalList[4];

        Animal tiger = new Tiger();
        tiger.AskingForFood();

        var foodType = food.GetType().Name;
        if (foodType == "Meat")
        {
            tiger = new Tiger(animalName, animalWeight, food.Quantity, animalLivingRegion, animalBreed);
        }
        else
        {
            Console.WriteLine($"{animalType} does not eat {foodType}!");
            tiger = new Tiger(animalName, animalWeight, 0, animalLivingRegion, animalBreed);
        }

        animals.Add(tiger);
    }

    private static void FeedCat(string[] animalList, Food food)
    {
        var animalType = animalList[0];
        var animalName = animalList[1];
        var animalWeight = double.Parse(animalList[2]);
        var animalLivingRegion = animalList[3];
        var animalBreed = animalList[4];

        Animal cat = new Cat();
        cat.AskingForFood();

        var foodType = food.GetType().Name;
        if (foodType == "Meat" || foodType == "Vegetable")
        {
            cat = new Cat(animalName, animalWeight, food.Quantity, animalLivingRegion, animalBreed);
        }
        else
        {
            Console.WriteLine($"{animalType} does not eat {foodType}!");
            cat = new Cat(animalName, animalWeight, 0, animalLivingRegion, animalBreed);
        }

        animals.Add(cat);
    }

    private static void FeedDog(string[] animalList, Food food)
    {
        var animalType = animalList[0];
        var animalName = animalList[1];
        var animalWeight = double.Parse(animalList[2]);
        var animalLivingRegion = animalList[3];

        Animal dog = new Dog();
        dog.AskingForFood();

        var foodType = food.GetType().Name;
        if (foodType == "Meat")
        {
            dog = new Dog(animalName, animalWeight, food.Quantity, animalLivingRegion);
        }
        else
        {
            Console.WriteLine($"{animalType} does not eat {foodType}!");
            dog = new Dog(animalName, animalWeight, 0, animalLivingRegion);
        }

        animals.Add(dog);
    }

    private static void FeedMouse(string[] animalList, Food food)
    {
        var animalType = animalList[0];
        var animalName = animalList[1];
        var animalWeight = double.Parse(animalList[2]);
        var animalLivingRegion = animalList[3];

        Animal mouse = new Mouse();
        mouse.AskingForFood();

        var foodType = food.GetType().Name;
        if (foodType == "Vegetable" || foodType == "Fruit")
        {
            mouse = new Mouse(animalName, animalWeight, food.Quantity, animalLivingRegion);
        }
        else
        {
            Console.WriteLine($"{animalType} does not eat {foodType}!");
            mouse = new Mouse(animalName, animalWeight, 0, animalLivingRegion);
        }

        animals.Add(mouse);
    }

    private static void FeedHen(string[] animalList, Food food)
    {
        var animalType = animalList[0];
        var animalName = animalList[1];
        var animalWeight = double.Parse(animalList[2]);
        var animalWingSize = double.Parse(animalList[3]);

        Animal hen = new Hen(animalName, animalWeight, food.Quantity, animalWingSize);
        hen.AskingForFood();
        animals.Add(hen);
    }

    private static void FeedOwl(string[] animalList, Food food)
    {
        var animalType = animalList[0];
        var animalName = animalList[1];
        var animalWeight = double.Parse(animalList[2]);
        var animalWingSize = double.Parse(animalList[3]);

        Animal owl = new Owl();
        owl.AskingForFood();

        var foodType = food.GetType().Name;
        if (foodType == "Meat")
        {
            owl = new Owl(animalName, animalWeight, food.Quantity, animalWingSize);
        }
        else
        {
            Console.WriteLine($"{animalType} does not eat {foodType}!");
            owl = new Owl(animalName, animalWeight, 0, animalWingSize);
        }

        animals.Add(owl);
    }
}