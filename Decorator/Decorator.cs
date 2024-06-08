namespace Decorator;

public abstract class Decorator(ICar car) : ICar
{
    public virtual string GetName() => car.GetName();

    public virtual double GetPrice() => car.GetPrice();
}
