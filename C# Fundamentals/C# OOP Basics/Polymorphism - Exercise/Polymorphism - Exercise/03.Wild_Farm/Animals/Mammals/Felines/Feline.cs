using System;
using System.Collections.Generic;
using System.Text;

public abstract class Feline : Mammal
{
    public Feline()
    {

    }

    public Feline(string name, double weight, int foodEaten, string livingRegion) 
        : base(name, weight, foodEaten, livingRegion)
    {
    }
}