namespace Observer;

public class ConcreteObserver(ConcreteSubject subject) : Observer
{
    string observerState;

    public override void Update()
    {
        observerState = subject.State;
        Console.WriteLine($"State updated - {observerState}");
    }
}
