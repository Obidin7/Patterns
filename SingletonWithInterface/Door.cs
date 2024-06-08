namespace SingletonWithInterface;

public class Door : IDoor
{
    public Guid Id { get; set; }

    public Door()
    {
        Id = Guid.NewGuid();
    }
}
