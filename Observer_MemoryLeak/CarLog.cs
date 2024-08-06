namespace Observer_MemoryLeak;

public class Carlog
{
    private readonly Car _car;

    public Carlog(Car car)
    {
        _car = car;
        _car.CarCrashed += CarCrashedLog;
    }

    private void CarCrashedLog(object sender, EventArgs eventArgs)
    {
        Console.WriteLine("Car was crashed (CarLog handler)");
    }

    ~Carlog()
    {
        Console.WriteLine("Carlog removed");
    }
}
