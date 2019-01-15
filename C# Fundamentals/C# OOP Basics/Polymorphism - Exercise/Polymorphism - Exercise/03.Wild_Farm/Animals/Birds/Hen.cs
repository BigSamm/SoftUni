using System;
using System.Collections.Generic;
using System.Text;

public class Hen : Bird
{
    public Hen()
    {

    }

    public Hen(string name, double weight, int foodEaten, double wingSize) 
        : base(name, weight, foodEaten, wingSize)
    {
    }

    public override void AskingForFood()
    {
        Console.WriteLine("Cluck");
    }

    public override void CalculateWeight()
    {
        base.Weight += base.FoodEaten * .35;
    }

    public override string ToString()
    {
        return $"Hen [{base.Name}, {base.WingSize}, {base.Weight}, {base.FoodEaten}]";
    }
}