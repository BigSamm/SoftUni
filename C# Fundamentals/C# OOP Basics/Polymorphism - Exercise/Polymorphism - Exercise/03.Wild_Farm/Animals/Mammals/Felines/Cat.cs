using System;
using System.Collections.Generic;
using System.Text;

public class Cat : Feline
{
    public Cat()
    {

    }

    public Cat(string name, double weight, int foodEaten, string livingRegion, string breed) 
        : base(name, weight, foodEaten, livingRegion)
    {
        this.Breed = breed;
    }

    public string Breed { get; set; }

    public override void AskingForFood()
    {
        Console.WriteLine("Meow");
    }

    public override void CalculateWeight()
    {
        base.Weight += base.FoodEaten * .3;
    }

    public override string ToString()
    {
        return $"Cat [{base.Name}, {this.Breed}, {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]";
    }
}