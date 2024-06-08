namespace AbstractFactory;

public class Car : ICar
{
    public void CreateEconomyCar() => Console.WriteLine("Creating Economy Car");

    public void CreateSportCar() => Console.WriteLine("Creating Sport Car");
}
