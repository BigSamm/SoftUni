using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Pizza pizza = TakePizza();

        TryAddDough(pizza);

        string inputLine;
        while ((inputLine = Console.ReadLine()) != "END")
        {
            TryAddCurrentTopping(inputLine, pizza);
        }

        Console.WriteLine(pizza);
    }

    private static void TryAddCurrentTopping(string inputLine, Pizza pizza)
    {
        var toppingList = inputLine.Split();
        var toppingType = toppingList[1];
        var toppingWeight = int.Parse(toppingList[2]);

        try
        {
            var topping = new Topping(toppingType, toppingWeight);
            pizza.TryAddTopping(topping);
        }
        catch (ArgumentException ex)
        {
            EndProgram(ex);
        }
    }

    private static void TryAddDough(Pizza pizza)
    {
        var doughList = Console.ReadLine().Split();
        var flourType = doughList[1];
        var bakingTechnique = doughList[2];
        var doughWeight = int.Parse(doughList[3]);

        try
        {
            var dough = new Dough(flourType, bakingTechnique, doughWeight);
            pizza.Dough = dough;
        }
        catch (ArgumentException ex)
        {
            EndProgram(ex);
        }
    }

    private static void EndProgram(ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        Environment.Exit(0);
    }

    private static Pizza TakePizza()
    {
        var pizzaList = Console.ReadLine().Split();
        var pizzaName = pizzaList[1];

        Pizza pizza = new Pizza();
        try
        {
            pizza = new Pizza(pizzaName);
        }
        catch (ArgumentException ex)
        {
            EndProgram(ex);
        }

        return pizza;
    }
}
