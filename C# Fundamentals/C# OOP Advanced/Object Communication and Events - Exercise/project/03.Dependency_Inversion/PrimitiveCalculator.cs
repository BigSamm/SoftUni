public class PrimitiveCalculator : IPrimitiveCalculator
{
    IStrategy strategy;

    public PrimitiveCalculator(IStrategy strategy)
    {
        this.ChangeStrategy(strategy);
    }

    public void ChangeStrategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public int PerformCalculation(int firstOperand, int secondOperand)
    {
        var result = strategy.Calculate(firstOperand, secondOperand);
        return result;
    }
}