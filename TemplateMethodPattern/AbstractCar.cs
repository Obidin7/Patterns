namespace TemplateMethodPattern;

public abstract class AbstractCar
{
    public void MakeCar()
    {
        MakeOuterPart();
        MakeMainPart();
    }

    protected abstract void MakeOuterPart();
    protected abstract void MakeMainPart();
}
