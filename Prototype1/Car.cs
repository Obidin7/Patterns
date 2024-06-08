namespace Prototype1;

public class Car : ICloneable
{
    public string Model { get; set; }
    public string Color { get; set; }

    public Car(string model, string color)
    {
        Model = model;
        Color = color;
    }

    public Car Copy()
    {
        return (Car)MemberwiseClone();
    }

    public object Clone()
    {
        var clone = (Car)MemberwiseClone();
        return clone;
    }
}
