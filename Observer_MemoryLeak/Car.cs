namespace Observer_MemoryLeak;

public class Car
{
    public event EventHandler CarCrashed;

    public void Crash()
    {
        CarCrashed?.Invoke(this, EventArgs.Empty);
    }

    ~Car()
    {
        Console.WriteLine("Car was removed");
    }
}
