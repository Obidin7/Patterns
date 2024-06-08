using StorageConnectionFactoryMethod;

var connectionFactory = new MsSqlConnectionFactory("1234");
await DatabaseQuery(connectionFactory);

Console.WriteLine("\n------------------------------------------\n");

var connectionFactory1 = new OracleConnectionFactory("12345");
await DatabaseQuery(connectionFactory1);

Console.WriteLine("\n------------------------------------------\n");

await DatabaseQueryAsync<MySqlConnection>("123456");

Console.WriteLine("\n------------------------------------------\n");

Func<Task<IStorageConnection>> sqlConnectionFactory
            = () => OpenPostgreSqlConnectionAsync("1234567");

await SomeDatabaseQuery(sqlConnectionFactory);

static async ValueTask DatabaseQuery(IStorageConnectionFactory connectionFactory)
{
    await using var connecion = await connectionFactory.CreateAsync();
    await connecion.ExecuteAsync("SELECT COUNT(1) FROM root;");
}

static async Task DatabaseQueryAsync<TConnection>(string connectionString)
        where TConnection : IStorageConnection, IHaveFactoryMethod<TConnection, string>
{
    await using var connecion = TConnection.Create(connectionString);
    await connecion.OpenAsync();
    await connecion.ExecuteAsync("SELECT COUNT(1) FROM root;");
}

static async Task<IStorageConnection> OpenPostgreSqlConnectionAsync(string connectionString)
{
    var connection = new OracleConnection(connectionString);
    await connection.OpenAsync();
    return connection;
}

static async Task SomeDatabaseQuery(Func<Task<IStorageConnection>> connectionFactory)
{
    await using var connecion = await connectionFactory.Invoke();
    await connecion.ExecuteAsync("SELECT COUNT(1) FROM root;");
}