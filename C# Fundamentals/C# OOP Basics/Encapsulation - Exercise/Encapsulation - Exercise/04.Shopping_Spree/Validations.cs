using System;
using System.Collections.Generic;
using System.Text;

public class Validations
{
    public static void ValidateName(string name)
    {
        if (String.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty");
    }

    public static void ValidateMoney(decimal money)
    {
        if (money < 0)
            throw new ArgumentException("Money cannot be negative");
    }
}
