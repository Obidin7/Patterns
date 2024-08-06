namespace FactoryMethodWithParameter;

public interface ISerializer
{
    string Serialize<T>(T value) where T : class;
    T? Deserialize<T>(string fromString) where T : class;
}
