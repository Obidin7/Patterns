namespace Composite;

public class Assembly(string name) : Component(name)
{
    private readonly List<Component> _parts = new();

    public void AddPart(Component part)
    {
        _parts.Add(part);
    }

    public override void GetName(int depth = 0)
    {
        Console.WriteLine(new string('-', depth) + "+ " + Name + " (Composite)");

        foreach (Component component in _parts)
        {
            component.GetName(depth + 2);
        }
    }
}
