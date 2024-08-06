namespace SingletonWithInterface;

public interface ISingleton<T> where T : ISingleton<T>
{
    abstract static T Instance { get; }
}
