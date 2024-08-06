using System.Reactive.Linq;

namespace ObserverI;

public class Start // : IObserver<Event>
{
    public Start()
    {
        var person = new PostOffice();
        //var sub = person.Subscribe(this);

        person.OfType<ParcelDeliveredEventArgs>()
         .Subscribe(args => Console.WriteLine($"The package was delivered to the address: {args.Address}"));

        person.CatchDelivery();
    }

    //public void OnNext(Event value)
    //{
    //    if (value is FallsIllEvent args)
    //        Console.WriteLine($"A doctor has been called to {args.Address}");
    //}

    //public void OnError(Exception error) { }
    //public void OnCompleted() { }
}
