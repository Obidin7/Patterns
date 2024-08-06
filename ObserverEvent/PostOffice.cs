namespace ObserverEvent;

public class PostOffice
{
    public void CatchDeliveredParcel()
    {
        ParcelDelivered?.Invoke(this,
          new ParcelDeliveredEventArgs { Address = "Dnipro, Kalinovaya 54 str." });
    }

    public event EventHandler<ParcelDeliveredEventArgs> ParcelDelivered;
}
