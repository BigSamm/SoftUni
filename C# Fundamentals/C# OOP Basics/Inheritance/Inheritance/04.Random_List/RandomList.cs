using System;
using System.Collections.Generic;
using System.Text;

public class RandomList : List<string>
{
    public List<string> List { get; set; }

    Random random = new Random();

    public string RandomString()
    {
        var index = random.Next();

        return List[index];
    }
}
