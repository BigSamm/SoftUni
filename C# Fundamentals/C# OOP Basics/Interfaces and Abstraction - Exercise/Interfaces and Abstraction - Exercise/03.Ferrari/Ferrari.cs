using System;
using System.Collections.Generic;
using System.Text;

public class Ferrari : ICar
{
    public string Model { get; private set; } 
    public string DriverName { get; private set; }

    public Ferrari(string driverName)
    {
        Model = "488-Spider";
        DriverName = driverName;
    }

    public string PushBreaks()
    {
        return "Brakes!";
    }

    public string PushGasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{Model}/{PushBreaks()}/{PushGasPedal()}/{DriverName}";
    }
}
