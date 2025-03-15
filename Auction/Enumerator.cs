namespace Auction;

public interface IEnumerator
{
    bool MoveNext();
    void Reset();
    object Current { get; }
}

public interface IEnumerable
{
    IEnumerator GetEnumerator();
}
