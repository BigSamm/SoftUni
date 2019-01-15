using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    public string Model { get; set; }
    public int Speed { get; set; }

    public Car()
    {
        Model = "";
    }

    public Car(string model, string speedStr)
    {
        Model = model;
        Speed = int.Parse(speedStr);
    }

    public override string ToString()
    {
        return $"{Model} {Speed}";
    }
}
