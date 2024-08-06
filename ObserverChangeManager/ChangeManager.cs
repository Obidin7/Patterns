namespace ObserverChangeManager;

public abstract class ChangeManager
{
    protected Dictionary<Subject, List<Observer>>? mapping = null;

    public ChangeManager() => mapping = [];

    public abstract void Register(Subject subject, Observer observer);
    public abstract void UnRegister(Subject subject, Observer observer);
    public abstract void Notify();
}
