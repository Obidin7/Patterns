namespace Proxy;

public class Light : ILight
{
    public void LightOn() => Console.WriteLine("Light is on");

    public void LightOff() => Console.WriteLine("Light is off");
}
