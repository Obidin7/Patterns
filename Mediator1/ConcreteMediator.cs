namespace Mediator1;

public class ConcreteMediator : Mediator
{
    public ConcreteContractor1 Colleague1 { get; set; }
    public ConcreteContractor2 Colleague2 { get; set; }

    public override void Send(string message, Contractor colleague)
    {
        if (Colleague1 == colleague)
        {
            Colleague2.Notify(message);
        }
        else
        {
            Colleague1.Notify(message);
        }
    }
}
