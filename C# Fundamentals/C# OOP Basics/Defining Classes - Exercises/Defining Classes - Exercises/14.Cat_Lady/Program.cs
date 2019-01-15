using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var cats = new List<Cat>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var inputList = input.Split();
            var breed = inputList[0];
            var name = inputList[1];

            Cat cat = new Cat();
            switch (breed)
            {
                case "Siamese":
                    var earSize = int.Parse(inputList[2]);
                    cat = new Siamese(breed, name, earSize);
                    break;
                case "Cymric":
                    var furLength = double.Parse(inputList[2]);
                    cat = new Cymric(breed, name, furLength);
                    break;
                case "StreetExtraordinaire":
                    var meowDecibels = int.Parse(inputList[2]);
                    cat = new StreetExtraordinaire(breed, name, meowDecibels);
                    break;
            }
            cats.Add(cat);
        }

        var catName = Console.ReadLine();
        var catForPrint = cats.Find(c => c.Name == catName);
        Console.WriteLine(catForPrint);
    }
}