namespace VisitorPattern;

public abstract class Visitor
{
    public abstract void VisitProprietorships(Proprietorship proprietorship);
    public abstract void VisitLlcs(Llc llc);
}
