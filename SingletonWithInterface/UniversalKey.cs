namespace SingletonWithInterface;

public class UniversalKey : ISingleton<UniversalKey>, IDoor
{
    private static readonly Lazy<UniversalKey> _instance = new(() => new UniversalKey());

    public static UniversalKey Instance => _instance.Value;

    public Guid Id { get; set; }

    private UniversalKey()
    {
        Id = Guid.NewGuid();
    }
}
