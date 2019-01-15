using System;
using System.Collections.Generic;
using System.Text;

public class Child
{
    public string Name { get; set; }
    public string Birthday { get; set; }

    public Child()
    { }

    public Child(string name, string birthday)
    {
        Name = name;
        Birthday = birthday;
    }

    public override string ToString()
    {
        return $"{Name} {Birthday}";
    }
}
