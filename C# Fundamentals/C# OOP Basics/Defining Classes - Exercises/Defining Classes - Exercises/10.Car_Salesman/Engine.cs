using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    public string Model { get; set; }
    public int Power { get; set; }
    public string Displacement { get; set; }
    public string Efficiency { get; set; }

    public Engine(string model, string powerStr, string displacement, string efficiency)
    {
        Model = model;
        Power = int.Parse(powerStr);
        Displacement = displacement;
        Efficiency = efficiency;
    }

    public override string ToString()
    {
        return $"{Model}:\n" +
               $"    Power: {Power}\n" +
               $"    Displacement: {Displacement}\n" +
               $"    Efficiency: {Efficiency}\n";
    }
}
