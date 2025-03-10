namespace Flyweight;

class UnsharedConcreteFlyweight : FlyweightBase
{
    private readonly string _allState = "UnsharedConcreteFlyweight";

    public override void Operation(ConsoleColor extrinsicState)
    {
        Console.ForegroundColor = extrinsicState;
        Console.WriteLine(_allState + GetHashCode());
    }
}
