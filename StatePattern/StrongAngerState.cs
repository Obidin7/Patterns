namespace StatePattern;

internal class StrongAngerState : State
{
    internal StrongAngerState()
    {
        Console.WriteLine("The owner's pissed:");
        FireEmployees();
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

    private static void FireEmployees() => Console.WriteLine("Fires all the employees.");
}
