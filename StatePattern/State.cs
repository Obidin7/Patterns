namespace StatePattern;

internal abstract class State
{
    internal virtual void HandleProfit(Owner owner, Profit profit)
    {
        ChangeState(owner, profit);
    }

    protected abstract void ChangeState(Owner owner, Profit profit);
}
