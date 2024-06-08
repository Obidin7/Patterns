namespace Adapter;

public class AdapterOpenLockByFingerOjectLevel(OpenLockByFinger openLockByFinger) : IOpenLock
{
    private readonly OpenLockByFinger _openLockByFinger = openLockByFinger;

    public AdapterOpenLockByFingerOjectLevel()
        : this(new OpenLockByFinger())
    {
    }

    public virtual void Open()
    {
        Console.WriteLine("object level adapter");
        _openLockByFinger.OpenByFinger();
    }
}
