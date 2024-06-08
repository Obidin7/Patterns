namespace GenericPrototype;

public record Car : IPrototype<Car>
{
    public string Model { get; set; }

    public Car(string model)
    {
        Model = model;
    }

    public Car Copy()
    {
        return (Car)MemberwiseClone();
    }
}
