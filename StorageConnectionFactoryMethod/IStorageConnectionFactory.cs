namespace StorageConnectionFactoryMethod;

public interface IStorageConnectionFactory
{
    ValueTask<IStorageConnection> CreateAsync();
}
