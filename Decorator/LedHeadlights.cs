namespace Decorator;

public class LedHeadlights(ICar decoratedCar) : Decorator(decoratedCar)
{
    public override string GetName() => $"{base.GetName()} with LED Headlights";

    public override double GetPrice() => base.GetPrice() + 1000.0;
}
