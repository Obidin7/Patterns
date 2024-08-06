namespace Adapter;

internal class AdapterOpenLockByFingerClassLevel : OpenLockByFinger, IOpenLock
{
    public void Open()
    {
        Console.WriteLine("class level adapter");
        OpenByFinger();
    }
}
