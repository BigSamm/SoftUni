using System;

public class StartUp
{
    static void Main()
    {
        IStrategyFactory strategyFactory = new StrategyFactory();

        var additionStrategy = strategyFactory.CreateStrategy("+");
        IPrimitiveCalculator primitiveCalculator = new PrimitiveCalculator(additionStrategy);

        Engine engine = new Engine(primitiveCalculator, strategyFactory);
        engine.Run();
    }
}