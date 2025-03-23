namespace Memento;

public class Originator
{
    public string State { get; set; }

    public void SetMemento(IWideInterface memento)
    {
        State = memento.State;
    }

    public INarrowInterface CreateMemento()
    {
        return new MementoR(State);
    }
}
