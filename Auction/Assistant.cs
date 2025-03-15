namespace Auction;

public class Assistant(AuctionHouse enumerable) : IEnumerator
{
    private readonly AuctionHouse auction = enumerable;
    private int current = -1;

    public bool MoveNext()
    {
        if (current < auction.Count - 1)
        {
            current++;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        current = -1;
    }

    public object Current
    {
        get { return auction[current]; }
    }
}
