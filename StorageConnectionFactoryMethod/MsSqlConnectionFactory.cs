namespace StorageConnectionFactoryMethod;

public class MsSqlConnectionFactory : IStorageConnectionFactory
{
    private readonly string _connectionString;

    public MsSqlConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async ValueTask<IStorageConnection> CreateAsync()
    {
        var connection = new MsSqlConnection(_connectionString);
        await connection.OpenAsync();

        return connection;
    }
}
