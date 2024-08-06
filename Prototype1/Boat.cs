using System.Text.Json;

namespace Prototype1;

public class Boat
{
    public Info Information { get; set; } = new();

    public Boat(string model, string color)
    {
        Information.Model = model;
        Information.Color = color;
    }

    public Boat()
    {
    }

    public Boat Copy()
    {
        return (Boat)MemberwiseClone();
    }

    public Boat DeepCopy()
    {
        var clone = new Boat
        {
            Information = new Info
            {
                Model = Information.Model,
                Color = Information.Color
            }
        };

        return clone;
    }

    public Boat SereliazationCopy()
    {
        var json = JsonSerializer.Serialize(this);
        return JsonSerializer.Deserialize<Boat>(json);
    }
}

public class Info
{
    public string Model { get; set; }
    public string Color { get; set; }
}
