namespace Observer_MemoryLeak;

public class Carlog
{
    private readonly Car car;

    public Carlog(Car car)
    {
        this.car = car;
        car.CarCrashed += CarCrashed;
    }

    private void CarCrashed(object sender, EventArgs eventArgs)
    {
        Console.WriteLine("Car was crashed (CarLog handler)");
    }

    ~Carlog()
    {
        Console.WriteLine("Carlog removed");
    }
}
