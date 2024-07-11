namespace Composite;

public abstract class Component(string name)
{
    protected readonly string Name = name;

    public abstract void GetName(int depth = 0);
}
