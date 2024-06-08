using System.Collections.Concurrent;

namespace Multiton;

public class UniversalKey : IMultiton<UniversalKey, KeyType>, IDoor
{
    private static readonly ConcurrentDictionary<KeyType, Lazy<UniversalKey>> _instances = new()
    {
        [KeyType.LowSecurity] = new Lazy<UniversalKey>(() => new UniversalKey(KeyType.LowSecurity)),
        [KeyType.HighSecurity] = new Lazy<UniversalKey>(() => new UniversalKey(KeyType.HighSecurity)),
    };

    public Guid Id { get; set; }

    public KeyType KeyType { get; }

    private UniversalKey(KeyType keyType)
    {
        Id = Guid.NewGuid();
        KeyType = keyType;
    }

    public static UniversalKey Instance(KeyType keyType)
    {
        return _instances.TryGetValue(keyType, out var lazy) ? lazy.Value : throw new ArgumentException("Unexpected Key type");
    }
}
