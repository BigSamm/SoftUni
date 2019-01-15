using System;

public class Validations
{
    public static void ValidateWeight(int value, string type, int minWeight, int maxWeight)
    {
        if (value < minWeight || value > maxWeight)
        {
            //type = type[0].ToString().ToUpper() + type.Substring(1).ToLower();
            throw new ArgumentException($"{type} weight should be in the range [{minWeight}..{maxWeight}].");
        }
    }
}
