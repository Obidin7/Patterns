namespace Auction;

public class AuctionHouse : IEnumerable
{
    private readonly List<Car> carsVault = [new(), new(), new(), new()];

    public Car this[int index]
    {
        get { return carsVault[index]; }
        set { carsVault.Insert(index, value); }
    }

    public int Count
    {
        get { return carsVault.Count; }
    }

    public IEnumerator GetEnumerator()
    {
        return new Assistant(this);
    }
}
