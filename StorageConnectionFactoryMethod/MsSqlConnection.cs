
namespace StorageConnectionFactoryMethod;

public class MsSqlConnection : IStorageConnection
{
    private readonly string _connectionString;

    public MsSqlConnection(string connectionString)
    {
        _connectionString = connectionString;
        Console.WriteLine($"MsSql connection to '{_connectionString}' created.");
    }
    public ValueTask OpenAsync()
    {
        Console.WriteLine("Open MsSql connection");
        return ValueTask.CompletedTask;
    }

    public ValueTask ExecuteAsync(string query)
    {
        Console.WriteLine($"Execute MsSql query - {query}");
        return ValueTask.CompletedTask;
    }

    public ValueTask CloseAsync()
    {
        Console.WriteLine("Close MsSql connection");
        return ValueTask.CompletedTask;
    }

    public async ValueTask DisposeAsync() => await CloseAsync();
}
