namespace VisitorPattern;

public class Llc : Element
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitLlcs(this);
    }

    public void ProvideDocuments()
    {
        Console.WriteLine("Provide documents for verification.");
    }
}
