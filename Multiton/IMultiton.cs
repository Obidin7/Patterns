namespace Multiton;

public interface IMultiton<T, K> where T : IMultiton<T, K>
{
    K KeyType { get; }

    abstract static T Instance(K keyType);
}
