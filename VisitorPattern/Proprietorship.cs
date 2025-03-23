namespace VisitorPattern;

public class Proprietorship : Element
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitProprietorships(this);
    }

    public void BribingTaxInspector()
    {
        Console.WriteLine("Agree on the successful outcome of the audit.");
    }
}
