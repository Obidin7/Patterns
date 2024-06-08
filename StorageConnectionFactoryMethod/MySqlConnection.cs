namespace StorageConnectionFactoryMethod;

public class MySqlConnection : IStorageConnection, 
    IHaveFactoryMethod<MySqlConnection, string>,
    IHaveFactoryMethodAsync<MySqlConnection, string>
{
    private readonly string _connectionString;

    public MySqlConnection(string connectionString)
    {
        _connectionString = connectionString;
        Console.WriteLine($"MySql connection to '{_connectionString}' created.");
    }
    public ValueTask OpenAsync()
    {
        Console.WriteLine("Open MySql connection");
        return ValueTask.CompletedTask;
    }

    public ValueTask ExecuteAsync(string query)
    {
        Console.WriteLine($"Execute MySql query - {query}");
        return ValueTask.CompletedTask;
    }

    public ValueTask CloseAsync()
    {
        Console.WriteLine("Close MySql connection");
        return ValueTask.CompletedTask;
    }

    public async ValueTask DisposeAsync() => await CloseAsync();

    public static MySqlConnection Create(string connectionString)
    {
        return new MySqlConnection(connectionString);
    }

    public static async ValueTask<MySqlConnection> CreateAsync(string connectionString)
    {
        var connection = Create(connectionString);
        await connection.OpenAsync();

        return connection;
    }
}
