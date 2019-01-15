using System;
using System.Collections.Generic;
using System.Text;

class Cymric : Cat
{
    public double FurLength { get; set; }

    public Cymric(string breed, string name, double furLength)
    {
        Breed = breed;
        Name = name;
        FurLength = furLength;
    }

    public override string ToString()
    {
        return $"{Breed} {Name} {FurLength:f2}";
    }
}
