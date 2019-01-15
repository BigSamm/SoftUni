using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
    public List<Tier> AllTires { get; set; }

    public Car()
    {
        AllTires = new List<Tier>();
    }
}