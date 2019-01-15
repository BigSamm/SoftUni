using System;
using System.Collections.Generic;
using System.Text;

public class Tesla : Car, IElectricCar
{
    public int Battery { get; set; }

    public Tesla(string model, string color, int battery)
    {
        base.Model = model;
        base.Color = color;
        this.Battery = battery;
    }

    public override string ToString()
    {
        return $"{Color} Tesla {Model} with {Battery} Batteries\n" +
               $"{Start()}\n" +
               $"{Stop()}";
    }
}
