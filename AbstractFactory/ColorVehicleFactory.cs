namespace AbstractFactory;

public class ColorVehicleFactory : ICommonFactory
{
    public ICar CreateCar() => new YellowCar();

    public IBoat CreateBoat() => new GreenBoat();
}
