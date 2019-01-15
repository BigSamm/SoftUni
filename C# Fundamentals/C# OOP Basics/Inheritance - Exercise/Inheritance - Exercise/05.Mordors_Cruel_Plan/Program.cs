using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var foods = new List<Food>();

        var foodList = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var foodName in foodList)
        {
            var currentFood = new Food(foodName);
            foods.Add(currentFood);
        }

        var happinessPoints = 0;
        foods.ForEach(f => happinessPoints += f.happinessPoints);

        var mood = new Mood(happinessPoints);
        Console.WriteLine(mood.HappinessPoints);
        Console.WriteLine(mood.Status);
    }
}
