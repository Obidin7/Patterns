namespace TemplateMethodPattern;

public class GermanCar : AbstractCar
{
    protected override void MakeOuterPart()
    {
        Console.WriteLine("Done well.");
    }

    protected override void MakeMainPart()
    {
        Console.WriteLine("Done perfectly.");
    }
}
