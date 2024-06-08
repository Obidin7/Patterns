namespace Facade;

public class Car
{
    private Engine Engine { get; set; } = new();
    private HeadLight HeadLight { get; set; } = new();
    private Audio Audio { get; set; } = new();

    public void StartMoving()
    {
        Engine.TurnOn();
        HeadLight.TurnOn();
        Audio.TurnOn();
        Console.WriteLine("Car is moving forward\n");
    }

    public void StopMoving()
    {
        Engine.TurnOff();
        HeadLight.TurnOff();
        Audio.TurnOff();
        Console.WriteLine("Car stopped\n");
    }
}
