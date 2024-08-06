namespace ObserverChangeManager;

public class DAGChangeManager : ChangeManager, IEqualityComparer<Tuple<Subject, Observer>>
{
    static readonly DAGChangeManager singleton = new();

    public static DAGChangeManager Singleton
    {
        get { return singleton; }
    }

    private DAGChangeManager()
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
        var tuples = mapping.SelectMany(kv => kv.Value.Select(observer => new Tuple<Subject, Observer>(kv.Key, observer))).Distinct(this);

        foreach (var tuple in tuples)
        {
            tuple.Item2.Update(tuple.Item1);
        }
    }

    bool IEqualityComparer<Tuple<Subject, Observer>>.Equals(Tuple<Subject, Observer> x, Tuple<Subject, Observer> y)
    {
        return x.Item2.Equals(y.Item2);
    }

    int IEqualityComparer<Tuple<Subject, Observer>>.GetHashCode(Tuple<Subject, Observer> tuple)
    {
        return tuple.Item2.GetHashCode();
    }
}
