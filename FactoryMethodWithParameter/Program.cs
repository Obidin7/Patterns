
using FactoryMethodWithParameter;

var facotry = new SerializerFactory(SerializationType.Json);

var user = new User
{
    Name = "Bob",
    Email = "bob@gmail.com"
};

var serializer = facotry.CreateSerializer();
Console.WriteLine(serializer.Serialize(user));
