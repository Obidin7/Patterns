namespace FactoryMethodWithParameter;

public class SerializerFactory : ISerializerFactory
{
    private readonly SerializationType _serializationType;

    public SerializerFactory(SerializationType serializationType)
    {
        _serializationType = serializationType;
    }

    public ISerializer CreateSerializer()
    {
        return CreateSerializer(_serializationType);
    }

    public ISerializer CreateSerializer(SerializationType type)
    {
        return type switch
        {
            SerializationType.Json => new JsonSerializer(),
            SerializationType.Xml => new XmlSerializer(),
            _ => throw new ArgumentException("Invalid type", nameof(type))
        };
    }
}
