namespace AbstractFactory;

public class YellowCar : ICar
{
    public void CreateSportCar()
    {
        var foregroundColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("Creating Yellow Sport Car");

        Console.ForegroundColor = foregroundColor;
    }

    public void CreateEconomyCar()
    {
        var foregroundColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("Creating Yellow Economy Car");

        Console.ForegroundColor = foregroundColor;
    }
}
