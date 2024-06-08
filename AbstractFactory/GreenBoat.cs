namespace AbstractFactory;

public class GreenBoat : IBoat
{
    public void CreateMotorBoat()
    {
        var foregroundColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Creating Green Motor Boat");

        Console.ForegroundColor = foregroundColor;
    }

    public void CreateSailBoat()
    {
        var foregroundColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Creating Green Sail Boat");

        Console.ForegroundColor = foregroundColor;
    }
}
