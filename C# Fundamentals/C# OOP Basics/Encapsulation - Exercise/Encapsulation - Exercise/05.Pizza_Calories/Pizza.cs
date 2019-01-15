using System;
using System.Collections.Generic;
using System.Text;

public class Pizza
{
    private const int MAX_NAME_LENGTH = 15;
    private const int MIN_TOPPINGS_COUNT = 0;
    private const int MAX_TOPPINGS_COUNT = 10;

    private string name;
    private Dough dough;
    private List<Topping> toppings = new List<Topping>();

    public Pizza() { }

    public Pizza(string name)
    {
        Name = name;
    }

    public IReadOnlyList<Topping> Toppings
    {
        get { return toppings; }
    }
    
    public Dough Dough
    {
        get { return dough; }
        set { dough = value; }
    }
    
    public string Name
    {
        get { return name; }
        private set
        {
            if (String.IsNullOrWhiteSpace(value) || value.Length > MAX_NAME_LENGTH)
                throw new ArgumentException($"Pizza name should be between 1 and {MAX_NAME_LENGTH} symbols.");
            name = value;
        }
    }

    public void TryAddTopping(Topping topping)
    {
        if (toppings.Count >= MAX_TOPPINGS_COUNT)
            throw new ArgumentException($"Number of toppings should be in range [{MIN_TOPPINGS_COUNT}..{MAX_TOPPINGS_COUNT}].");
        else
            toppings.Add(topping);
    }

    public double CalculateCalories()
    {
        var doughCalories = dough.CalculateCalories();

        var toppingsCalories = .0;
        toppings.ForEach(t => toppingsCalories += t.CalculateCalories());

        var result = doughCalories + toppingsCalories;
        return result;
    }

    public override string ToString()
    {
        var calories = CalculateCalories();

        return $"{Name} - {calories:f2} Calories.";
    }
}
