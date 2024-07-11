namespace Observer_Push;

public class ConcreteObserver(ConcreteSubject subject) : Observer
{
    string observerState;

    public override void Update(string state)
    {
        observerState = state;
    }
}
