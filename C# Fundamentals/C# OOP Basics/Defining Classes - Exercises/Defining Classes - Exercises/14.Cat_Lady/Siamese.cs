using System;
using System.Collections.Generic;
using System.Text;

public class Siamese : Cat
{
    public int EarSize { get; set; }

    public Siamese(string breed, string name, int earSize)
    {
        Breed = breed;
        Name = name;
        EarSize = earSize;
    }

    public override string ToString()
    {
        return $"{Breed} {Name} {EarSize}";
    }
}
