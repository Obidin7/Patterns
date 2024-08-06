using Proxy;

var light = new AccessControlProxy("123");
light.LightOn();
light.LightOff();

Console.WriteLine();

light = new AccessControlProxy("1234");
light.LightOn();
light.LightOff();
