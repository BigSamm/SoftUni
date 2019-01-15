using System;
using System.Collections.Generic;
using System.Text;

public class TyreFactory
{
    public static Tyre CreateTyre(List<string> arguments)
    {
        var type = arguments[0];
        var hardness = double.Parse(arguments[1]);

        switch (type)
        {
            case "Ultrasoft":
                var grip = double.Parse(arguments[2]);
                if (grip <= 0)
                    throw new ArgumentException();
                return new UltrasoftTyre(hardness, grip);
            case "Hard":
                return new HardTyre(hardness);
            default:
                throw new ArgumentException();
        }
    }
}