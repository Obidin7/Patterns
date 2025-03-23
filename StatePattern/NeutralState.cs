namespace StatePattern;

internal class NeutralState : State
{
    internal NeutralState()
    {
        Console.WriteLine("Profit is satisfactory");
        Hope();
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
                    owner.State = new HappyState();
                    break;
                }
        }
    }

    // y3
    private static void Hope() => Console.WriteLine("Hopes for an increase in profits.");
}
