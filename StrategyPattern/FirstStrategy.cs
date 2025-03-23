namespace StrategyPattern;

public class FirstStrategy : Strategy
{
    public override void SendMessage()
    {
        Console.WriteLine("First Strategy");
    }
}
