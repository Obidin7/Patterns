namespace Bridge;

public abstract class Vehicle(IEngine engine)
{
    protected readonly IEngine Engine = engine;

    public abstract void Drive();
}
