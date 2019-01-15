using System;

public class Topping
{
    private static int MIN_WEIGHT = 1;
    private static int MAX_WEIGHT = 50;

    private string type;
    private int weight;

    public Topping(string type, int weight)
    {
        Type = type;
        Weight = weight;
    }

    public int Weight
    {
        get { return weight; }
        private set
        {
            Validations.ValidateWeight(value, type, MIN_WEIGHT, MAX_WEIGHT);
            weight = value;
        }
    }
    
    public string Type
    {
        get { return type; }
        private set
        {
            if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            type = value;
        }
    }

    public double CalculateCalories()
    {
        var toppingTypeMultiplier = Enum.Parse<ToppingTypeEnum>(type.ToLower());

        var result = Weight * 2.0 * (int)(toppingTypeMultiplier) / 10;
        return result;
    }
}
