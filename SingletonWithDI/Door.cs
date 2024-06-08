namespace SingletonWithDI;

public class Door
{
    public Guid Id { get; set; }

    public Door()
    {
        Id = Guid.NewGuid();
    }
}
