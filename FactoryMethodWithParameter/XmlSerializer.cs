namespace FactoryMethodWithParameter;

public class XmlSerializer : ISerializer
{
    public T? Deserialize<T>(string fromString) where T : class
    {
        System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
        using TextReader reader = new StringReader(fromString);
        return (T?)xmlSerializer.Deserialize(reader);
    }

    public string Serialize<T>(T value) where T : class
    {
        System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
        using StringWriter stringWriter = new();
        xmlSerializer.Serialize(stringWriter, value);
        return stringWriter.ToString();
    }
}
