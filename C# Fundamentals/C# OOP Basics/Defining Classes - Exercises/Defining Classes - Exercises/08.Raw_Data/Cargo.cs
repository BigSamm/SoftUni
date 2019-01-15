using System;
using System.Collections.Generic;
using System.Text;

public class Cargo
{
    public int CargoWeight { get; set; }
    public string CargoType { get; set; }

    public Cargo(string weightStr, string type)
    {
        CargoWeight = int.Parse(weightStr);
        CargoType = type;
    }
}
