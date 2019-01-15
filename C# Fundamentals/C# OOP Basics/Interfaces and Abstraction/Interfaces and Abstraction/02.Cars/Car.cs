using System;
using System.Collections.Generic;
using System.Text;

public abstract class Car : ICar
{
    public string Model { get; protected set; }
    public string Color { get; protected set; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }
}
