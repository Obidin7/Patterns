namespace TemplateMethodPattern;

public class ChineseCar : AbstractCar
{
    protected override void MakeOuterPart()
    {
        Console.WriteLine("Done perfectly.");
    }

    protected override void MakeMainPart()
    {
        Console.WriteLine("It's done so badly.");
    }
}
