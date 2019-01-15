using System;
using System.Collections.Generic;
using System.Text;

class StreetExtraordinaire : Cat
{
    public int MeowsDecibels { get; set; }

    public StreetExtraordinaire(string breed, string name, int meowDecibels)
    {
        Breed = breed;
        Name = name;
        MeowsDecibels = meowDecibels;
    }

    public override string ToString()
    {
        return $"{Breed} {Name} {MeowsDecibels}";
    }
}
