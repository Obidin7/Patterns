namespace ObserverDeclaratory;

public interface IEvent
{
}

public interface ISend<TEvent> where TEvent : IEvent
{
    event EventHandler<TEvent> Sender;
}

public interface IHandle<TEvent> where TEvent : IEvent
{
    void Handle(object sender, TEvent args);
}
