using System;
using System.Collections.Generic;
using System.Text;

public class Tier
{
    public double Pressure { get; set; }
    public int Age { get; set; }

    public Tier(double pressure, int age)
    {
        Pressure = pressure;
        Age = age;
    }
}
