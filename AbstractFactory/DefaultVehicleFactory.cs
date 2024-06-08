namespace AbstractFactory;

public class DefaultVehicleFactory : ICommonFactory
{
    public ICar CreateCar() => new Car();

    public IBoat CreateBoat() => new Boat();
}
