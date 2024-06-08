namespace StorageConnectionFactoryMethod;

public interface IHaveFactoryMethod<T, TParam1> where T : IHaveFactoryMethod<T, TParam1>
{
    abstract static T Create(TParam1 param1);
}

public interface IHaveFactoryMethodAsync<T, TParam1> where T : IHaveFactoryMethod<T, TParam1>
{
    abstract static ValueTask<T> CreateAsync(TParam1 param1);
}
