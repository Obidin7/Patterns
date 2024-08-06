namespace StorageConnectionFactoryMethod;

public class OracleConnectionFactory : IStorageConnectionFactory
{
    private readonly string _connectionString;

    public OracleConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async ValueTask<IStorageConnection> CreateAsync()
    {
        var connection = new OracleConnection(_connectionString);
        await connection.OpenAsync();

        return connection;
    }
}
