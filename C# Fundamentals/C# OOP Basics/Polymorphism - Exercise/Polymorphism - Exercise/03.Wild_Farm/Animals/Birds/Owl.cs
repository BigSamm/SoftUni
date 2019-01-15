using System;
using System.Collections.Generic;
using System.Text;

public class Owl : Bird
{
    public Owl()
    {

    }

    public Owl(string name, double weight, int foodEaten, double wingSize) 
        : base(name, weight, foodEaten, wingSize)
    {
    }

    public override void AskingForFood()
    {
        Console.WriteLine("Hoot Hoot");
    }

    public override void CalculateWeight()
    {
        base.Weight += base.FoodEaten * .25;
    }

    public override string ToString()
    {
        return $"Owl [{base.Name}, {base.WingSize}, {base.Weight}, {base.FoodEaten}]";
    }
}