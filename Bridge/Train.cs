namespace Bridge;

public class Train(IEngine engine) : Vehicle(engine)
{
    public override void Drive()
    {        
        Engine.TurnOn();
        Console.WriteLine("Train is moving.\n");
    }
}