public interface IStrategyFactory
{
    IStrategy CreateStrategy(string @operator);
}