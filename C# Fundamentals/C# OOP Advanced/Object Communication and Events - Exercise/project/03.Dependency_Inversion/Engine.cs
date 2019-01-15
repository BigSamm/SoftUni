using System;

public class Engine
{
    private IPrimitiveCalculator primitiveCalculator;
    private IStrategyFactory strategyFactory;

    public Engine(IPrimitiveCalculator primitiveCalculator, IStrategyFactory strategyFactory)
    {
        this.primitiveCalculator = primitiveCalculator;
        this.strategyFactory = strategyFactory;
    }

    internal void Run()
    {
        string inputLine;
        while ((inputLine = Console.ReadLine()) != "End")
        {
            var tokens = inputLine.Split();
            var command = tokens[0];
            
            if (command == "mode")
            {
                var @operator = tokens[1];
                IStrategy strategy = strategyFactory.CreateStrategy(@operator);
                primitiveCalculator.ChangeStrategy(strategy);
            }
            else
            {
                var firstOperand = int.Parse(tokens[0]);
                var secondOperand = int.Parse(tokens[1]);
                var result = primitiveCalculator.PerformCalculation(firstOperand, secondOperand);
                Console.WriteLine(result);
            }
        }
    }
}