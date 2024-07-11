namespace ObserverChangeManager;

public class Observer(string name)
{
    public string Name { get; private set; } = name;

    public void Update(Subject subject)
    {
        Console.WriteLine($"{subject.Name} -> {Name}");
    }
}
