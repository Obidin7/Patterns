using InternalIterator;

delegate double Function(double arg);

static double Power2(double n)
{
    return Math.Pow(n, 2);
}

private Enumerable enumerable = new();
IEnumerable power2List = enumerable.Transform(new Function(Power2));

foreach (var item in power2List)
{
    Console.WriteLine(item);
}

IEnumerable power3List = enumerable.Transform(n => Math.Pow(n, 3));

foreach (var item in power3List)
    Console.WriteLine(item);