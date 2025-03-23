namespace StrategyPattern;

public class Context(Strategy strategy)
{
    public void ContextInterface()
    {
        strategy.SendMessage();
    }
}
