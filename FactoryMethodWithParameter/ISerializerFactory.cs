namespace FactoryMethodWithParameter;

public interface ISerializerFactory
{
    ISerializer CreateSerializer();

    ISerializer CreateSerializer(SerializationType type);
}
