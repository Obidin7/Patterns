namespace StrategyPattern;

public class SecondStrategy : Strategy
{
    public override void SendMessage()
    {
        Console.WriteLine("Second Strategy");
    }
}