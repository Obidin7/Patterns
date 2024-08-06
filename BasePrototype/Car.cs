namespace BasePrototype;

public class Car : IPrototype
{
    public string Model { get; set; }

    public IPrototype Copy()
    {
        return (IPrototype)MemberwiseClone();
    }

    public Car(string model)
    {
        Model = model;
    }

    public Car CopyWithoutInterface()
    {
        return (Car)MemberwiseClone(); //Bad practice
    }
}
