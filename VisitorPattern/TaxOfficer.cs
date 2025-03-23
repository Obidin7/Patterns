namespace VisitorPattern;

public class TaxOfficer : Visitor
{
    public override void VisitProprietorships(Proprietorship proprietorship)
    {
        proprietorship.BribingTaxInspector();
    }

    public override void VisitLlcs(Llc llc)
    {
        llc.ProvideDocuments();
    }
}
