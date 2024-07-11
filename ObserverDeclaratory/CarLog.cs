namespace ObserverDeclaratory;

public class CarLog : IHandle<CarMaxSpeedEvent>
{
    public void Handle(object sender, CarMaxSpeedEvent args)
    {
        Console.WriteLine($"Car's max speed is {args.MaxSpeed}");
    }
}
