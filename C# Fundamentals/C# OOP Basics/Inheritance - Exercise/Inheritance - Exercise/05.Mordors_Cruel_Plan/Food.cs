using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Food : FoodFactory
{
    public Food(string name)
    {
        Name = name;
        happinessPoints = CalculateHappinessPoints(name);
    }

    private int CalculateHappinessPoints(string name)
    {
        var isContains = Enum.TryParse<FoodEnum>(name, true, out FoodEnum foodValue);

        if (!isContains)
            return -1;

        return (int)foodValue;
    }
}
