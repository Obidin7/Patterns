namespace Decorator;

public class Airbag(ICar decoratedCar) : Decorator(decoratedCar)
{
    public override string GetName() => $"{base.GetName()} with Airbag";

    public override double GetPrice() => base.GetPrice() + 500.0;
}
