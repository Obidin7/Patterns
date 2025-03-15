namespace Mediator1;

public abstract class Mediator
{
    public abstract void Send(string message, Contractor colleague);
}
