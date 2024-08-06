using ObserverEvent;

var person = new PostOffice();
person.ParcelDelivered += Inform;
person.CatchDeliveredParcel();

static void Inform(object sender, ParcelDeliveredEventArgs eventArgs)
{
    Console.WriteLine($"The package was delivered to the address: {eventArgs.Address}");
}