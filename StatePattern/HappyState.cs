namespace StatePattern;

internal class HappyState : State
{
    internal HappyState()
    {
        Console.WriteLine("The owner is happy:");
        Praise();
    }
    protected override void ChangeState(Owner owner, Profit profitLevel)
    {
        switch (profitLevel)
        {
            case Profit.Loss:
                {
                    owner.State = new WorryState();
                    break;
                }
            case Profit.Gain:
                {
                    owner.State = new SeventhHeavenState();
                    break;
                }
        }
    }

    private static void Praise() => Console.WriteLine("Praises the employees for the gain.");
}
