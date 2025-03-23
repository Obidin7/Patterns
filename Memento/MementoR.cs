namespace Memento;

public class MementoR(string state) : IWideInterface
{
    public string State { get; set; } = state;
}
