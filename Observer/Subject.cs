using System.Collections;

namespace Observer;

public class Subject
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

    public void Notify()
    {
        foreach (Observer observer in observers)
        {
            observer.Update();
        }            
    }
}
