using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var buyers = new List<IBuyer>();

        var linesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < linesCount; i++)
        {
            var inputList = Console.ReadLine().Split();
            if (inputList.Length == 3)
                AddRebel(inputList, buyers);
            else if (inputList.Length == 4)
                AddCitizen(inputList, buyers);
        }

        string inputLine;
        while((inputLine = Console.ReadLine()) != "End")
        {
            if (buyers.Any(p => p.Name == inputLine))
            {
                buyers.Find(b => b.Name == inputLine).BuyFood();
            }
        }

        var totalAmount = 0;
        buyers.ForEach(b => totalAmount += b.Food);
        Console.WriteLine(totalAmount);
    }

    private static void AddCitizen(string[] inputList, List<IBuyer> persons)
    {
        var name = inputList[0];
        var age = int.Parse(inputList[1]);
        var id = inputList[2];
        var birthdate = inputList[3];

        IBuyer citizen = new Citizen(name, age, id, birthdate);
        persons.Add(citizen);
    }

    private static void AddRebel(string[] inputList, List<IBuyer> persons)
    {
        var name = inputList[0];
        var age = int.Parse(inputList[1]);
        var group = inputList[2];

        IBuyer rebel = new Rebel(name, age, group);
        persons.Add(rebel);
    }
}
