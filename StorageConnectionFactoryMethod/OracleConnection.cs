namespace StorageConnectionFactoryMethod;

public class OracleConnection : IStorageConnection
{
    private readonly string _connectionString;

    public OracleConnection(string connectionString)
    {
        _connectionString = connectionString;
        Console.WriteLine($"Oracle connection to '{_connectionString}' created.");
    }
    public ValueTask OpenAsync()
    {
        Console.WriteLine("Open Oracle connection");
        return ValueTask.CompletedTask;
    }

    public ValueTask ExecuteAsync(string query)
    {
        Console.WriteLine($"Execute Oracle query - {query}");
        return ValueTask.CompletedTask;
    }

    public ValueTask CloseAsync()
    {
        Console.WriteLine("Close Oracle connection");
        return ValueTask.CompletedTask;
    }

    public async ValueTask DisposeAsync() => await CloseAsync();
}
