using System;
using System.Collections.Generic;
using System.Text;

public class Tiger : Feline
{
    public Tiger()
    {

    }

    public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed) 
        : base(name, weight, foodEaten, livingRegion)
    {
        this.Breed = breed;
    }

    public string Breed { get; set; }

    public override void AskingForFood()
    {
        Console.WriteLine("ROAR!!!");
    }

    public override void CalculateWeight()
    {
        base.Weight += base.FoodEaten * 1;
    }

    public override string ToString()
    {
        return $"Tiger [{base.Name}, {this.Breed}, {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]";
    }
}