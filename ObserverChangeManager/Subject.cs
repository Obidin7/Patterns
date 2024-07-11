namespace ObserverChangeManager;

public class Subject(string name, ChangeManager manager)
{
    readonly ChangeManager manager = manager;
    public string Name { get; private set; } = name;

    public void Subscribe(Observer observer)
    {
        manager.Register(this, observer);
    }

    public void UnSubscribe(Observer observer)
    {
        manager.UnRegister(this, observer);
    }

    public void Notify()
    {
        manager.Notify();
    }
}
