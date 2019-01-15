using System;
using System.Collections.Generic;
using System.Text;

public class Pokemon
{
    public string Name { get; set; }
    public string Element { get; set; }
    public int Health { get; set; }

    public Pokemon(string name, string element, string healthStr)
    {
        Name = name;
        Element = element;
        Health = int.Parse(healthStr);
    }
}
