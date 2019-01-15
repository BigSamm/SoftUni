using System;
using System.Collections.Generic;
using System.Text;

public class Mouse : Mammal
{
    public Mouse()
    {

    }

    public Mouse(string name, double weight, int foodEaten, string livingRegion) 
        : base(name, weight, foodEaten, livingRegion)
    {
    }

    public override void AskingForFood()
    {
        Console.WriteLine("Squeak");
    }

    public override void CalculateWeight()
    {
        base.Weight += base.FoodEaten * .1;
    }

    public override string ToString()
    {
        return $"Mouse [{base.Name}, {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]";
    }
}