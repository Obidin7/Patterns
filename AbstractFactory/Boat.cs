namespace AbstractFactory;

public class Boat : IBoat
{
    public void CreateMotorBoat() => Console.WriteLine("Creating Motor Boat");

    public void CreateSailBoat() => Console.WriteLine("Creating Sail Boat");
}
