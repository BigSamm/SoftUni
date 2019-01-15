using System;

public class StrategyFactory : IStrategyFactory
{
    public IStrategy CreateStrategy(string @operator)
    {
        IStrategy strategy = null;

        switch (@operator)
        {
            case "+":
                strategy = new AdditionStrategy();
                break;
            case "-":
                strategy = new SubtractionStrategy();
                break;
            case "*":
                strategy = new MultiplicationStrategy();
                break;
            case "/":
                strategy = new DivisionStrategy();
                break;
            default:
                throw new ArgumentException("Invalid Mode!");
        }

        return strategy;
    }
}