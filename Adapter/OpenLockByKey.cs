namespace Adapter;

public class OpenLockByKey : IOpenLock
{
    public void Open()
    {
        Console.WriteLine("Door is opened by key");
    }
}
