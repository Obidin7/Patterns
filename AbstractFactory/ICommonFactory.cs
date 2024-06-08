namespace AbstractFactory;

public interface ICommonFactory
{
    ICar CreateCar();

    IBoat CreateBoat();
}
