using System;
using System.Collections.Generic;
using System.Text;

public class Dog : Mammal
{
    public Dog()
    {

    }

    public Dog(string name, double weight, int foodEaten, string livingRegion) 
        : base(name, weight, foodEaten, livingRegion)
    {
    }

    public override void AskingForFood()
    {
        Console.WriteLine("Woof!");
    }

    public override void CalculateWeight()
    {
        base.Weight += base.FoodEaten * .4;
    }

    public override string ToString()
    {
        return $"Dog [{base.Name}, {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]";
    }
}