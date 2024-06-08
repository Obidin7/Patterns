namespace Proxy;

public class AccessControlProxy(string secret) : ILight
{
    private ILight _light;
    private ILight Light => _light ??= new Light();

    public void LightOn()
    {
        if (secret == "123")
        {
            Console.WriteLine("Access granted");
            Light.LightOn();
            return;
        }

        Console.WriteLine("Access denied");
    }

    public void LightOff()
    {
        if (secret == "123")
        {
            Console.WriteLine("Access granted");
            Light.LightOff();
            return;
        }

        Console.WriteLine("Access denied");
    }
}
