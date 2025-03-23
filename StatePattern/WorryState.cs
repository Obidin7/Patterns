namespace StatePattern;

internal class WorryState : State
{
    internal WorryState()
    {
        Console.WriteLine("The owner is concerned:");
        Calm();
    }

    protected override void ChangeState(Owner owner, Profit profitLevel)
    {
        switch (profitLevel)
        {
            case Profit.Loss:
                {
                    owner.State = new AngerState();
                    break;
                }
            case Profit.Gain:
                {
                    owner.State = new NeutralState();
                    break;
                }
        }
    }

    private static void Calm() => Console.WriteLine("Keeps employees calm.");
}
