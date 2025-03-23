namespace StatePattern;
// Context
public class Owner
{
    internal State State { get; set; }

    public Owner()
    {
        State = new NeutralState();
    }

    public void FindOut(Profit profit)
    {
        State.HandleProfit(this, profit);
    }
}
