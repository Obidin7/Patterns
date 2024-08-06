namespace Bridge;

public class Boat(IEngine engine) : Vehicle(engine)
{
    public override void Drive()
    {        
        Engine.TurnOn();
        Console.WriteLine("Boat is moving.\n");
    }
}
