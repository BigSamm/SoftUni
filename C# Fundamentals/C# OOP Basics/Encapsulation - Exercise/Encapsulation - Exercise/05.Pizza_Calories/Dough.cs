using System;

public class Dough
{
    private static int MIN_WEIGHT = 1;
    private static int MAX_WEIGHT = 200;

    private string flourType;
    private string bakingTechnique;
    private int weight;

    public Dough(string flourType, string bakingTechnique, int weight)
    {
        FlourType = flourType;
        BakingTechnique = bakingTechnique;
        Weight = weight;
    }

    public int Weight
    {
        get { return weight; }
        private set
        {
            Validations.ValidateWeight(value, "Dough", MIN_WEIGHT, MAX_WEIGHT);
            weight = value;
        }
    }
    
    public string BakingTechnique
    {
        get { return bakingTechnique; }
        private set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                ThrowDoughTypeException();
            bakingTechnique = value;
        }
    }

    public string FlourType
    {
        get { return flourType; }
        private set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                ThrowDoughTypeException();
            bakingTechnique = value;
            flourType = value;
        }
    }

    private void ThrowDoughTypeException()
    {
        throw new ArgumentException("Invalid type of dough.");
    }

    public double CalculateCalories()
    {
        var flourTypeMultiplier = Enum.Parse<FlourTypeEnum>(flourType.ToLower());
        var bakingTechniqueMultiplier = Enum.Parse<BakingTechniqueEnum>(bakingTechnique.ToLower());

        var result = Weight * 2.0 * (int)flourTypeMultiplier * (int)bakingTechniqueMultiplier / 100;
        return result;
    }
}
