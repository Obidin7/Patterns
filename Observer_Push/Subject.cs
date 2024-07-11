using System.Collections;

namespace Observer_Push;

public abstract class Subject
{
    ArrayList observers = [];

    public void Subscribe(Observer observer)
    {
        observers.Add(observer);
    }

    public void UnSubscribe(Observer observer)
    {
        observers.Remove(observer);
    }

    public abstract string State { get; set; }

    public void Notify()
    {
        foreach (Observer observer in observers)
        {
            observer.Update(State);
            Console.WriteLine($"State updated - {State}");
        }            
    }
}
