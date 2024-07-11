namespace ObserverChangeManager;

public class SimpleChangeManager : ChangeManager
{
    static readonly SimpleChangeManager singleton = new();

    public static SimpleChangeManager Singleton
    {
        get { return singleton; }
    }

    private SimpleChangeManager()
    {
    }

    public override void Register(Subject subject, Observer observer)
    {
        if (!mapping.ContainsKey(subject))
            mapping.Add(subject, []);

        mapping[subject].Add(observer);
    }

    public override void UnRegister(Subject subject, Observer observer)
    {
        if (!mapping.ContainsKey(subject))
            return;

        mapping[subject].Remove(observer);
    }

    public override void Notify()
    {
        foreach (var kvp in mapping)
        {
            foreach (var observer in kvp.Value)
            {
                observer.Update(kvp.Key);
            }
        }
    }
}
