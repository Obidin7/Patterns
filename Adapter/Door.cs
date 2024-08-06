namespace Adapter;

public class Door
{
    public void Open()
    {
        IOpenLock openLock = new OpenLockByKey();
        openLock.Open();

        openLock = new AdapterOpenLockByFingerOjectLevel();
        openLock.Open();

        openLock = new AdapterOpenLockByFingerClassLevel();
        openLock.Open();
    }
}
