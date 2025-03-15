namespace Mediator1;

public class ConcreteContractor1(Mediator mediator) : Contractor(mediator)
{
    public void Send(string message)
    {
        mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine(this + " got " + message);
    }
}
