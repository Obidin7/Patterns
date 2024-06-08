namespace SingletonWithDI;

public class UniversalKey
{
    public Guid Id { get; set; }

    public UniversalKey()
    {
        Id = Guid.NewGuid();
    }
}
