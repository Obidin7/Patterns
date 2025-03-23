namespace StatePattern;

internal class AngerState : State
{
    internal AngerState()
    {
        Console.WriteLine("The owner is angry:");
        Scold();
    }

    protected override void ChangeState(Owner owner, Profit profitLevel)
    {
        switch (profitLevel)
        {
            case Profit.Loss:
                {
                    owner.State = new StrongAngerState();
                    break;
                }
            case Profit.Gain:
                {
                    owner.State = new NeutralState();
                    break;
                }
        }
    }
  
    private static void Scold() => Console.WriteLine("Scolds the employees for the loss.");
}
