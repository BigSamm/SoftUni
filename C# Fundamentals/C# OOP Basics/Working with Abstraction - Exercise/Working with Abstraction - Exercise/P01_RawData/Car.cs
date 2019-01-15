using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
    public List<Tier> Tiers { get; set; }
    
    public Car(string model, Engine engine, Cargo cargo, Tier firstTier, Tier secondTier, Tier thirdTier, Tier fourthTier)
    {
        Model = model;
        Engine = engine;
        Cargo = cargo;

        Tiers = new List<Tier>();
        Tiers.Add(firstTier);
        Tiers.Add(secondTier);
        Tiers.Add(thirdTier);
        Tiers.Add(fourthTier);
    }
}
