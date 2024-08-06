namespace ObserverDeclaratory;

public class Car : ISend<CarMaxSpeedEvent>
{
    public event EventHandler<CarMaxSpeedEvent> Sender;

    public void UpdateMaxSpeed(int maxSpeed)
    {
        Sender?.Invoke(this, new CarMaxSpeedEvent
        {
            MaxSpeed = maxSpeed
        });
    }
}
