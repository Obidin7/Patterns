namespace Composite;

public class Part(string name) : Component(name)
{
    public override void GetName(int depth = 0)
    {
        Console.WriteLine(new string('-', depth) + Name + " (Leaf)");
    }
}
