namespace Decorator;

internal class CommonCar : ICar
{
    public string GetName()
    {
        return "Common Car";
    }

    public double GetPrice()
    {
        return 10000.0;
    }
}