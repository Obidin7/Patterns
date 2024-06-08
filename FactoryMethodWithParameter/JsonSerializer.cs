namespace FactoryMethodWithParameter;

public class JsonSerializer : ISerializer
{
    public T? Deserialize<T>(string fromString) where T : class
    {
        return System.Text.Json.JsonSerializer.Deserialize<T>(fromString);
    }

    public string Serialize<T>(T type) where T : class
    {
        return System.Text.Json.JsonSerializer.Serialize<T>(type);
    }
}
