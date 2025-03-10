namespace Flyweight;

class ConcreteFlyweight : FlyweightBase
{
    private readonly string _intrinsicState = "ConcreteFlyweight";
    ConsoleColor extrinsicState;

    public override void Operation(ConsoleColor extrinsicState)
    {
        this.extrinsicState = extrinsicState;
        Console.ForegroundColor = this.extrinsicState;
        Console.WriteLine(_intrinsicState + GetHashCode());
    }
}
