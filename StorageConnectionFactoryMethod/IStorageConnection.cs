namespace StorageConnectionFactoryMethod;

public interface IStorageConnection : IAsyncDisposable
{
    ValueTask OpenAsync();
    ValueTask ExecuteAsync(string query);
    ValueTask CloseAsync();
}
