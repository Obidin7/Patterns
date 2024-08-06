namespace ObserverI;

public class PostOffice : IObservable<Event>
{
    private readonly HashSet<Subscription> subscriptions = [];

    public IDisposable Subscribe(IObserver<Event> observer)
    {
        var subscription = new Subscription(this, observer);
        subscriptions.Add(subscription);
        return subscription;
    }

    public void CatchDelivery()
    {
        foreach (var sub in subscriptions)
            sub.Observer.OnNext(new ParcelDeliveredEventArgs { Address = "Kalinovaya 45 str." });
    }

    private class Subscription(PostOffice person, IObserver<Event> observer) : IDisposable
    {
        private PostOffice person = person;
        public IObserver<Event> Observer = observer;

        public void Dispose()
        {
            person.subscriptions.Remove(this);
        }
    }
}
