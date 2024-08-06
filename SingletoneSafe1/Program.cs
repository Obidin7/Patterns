using SingletonSafe1;

Parallel.For(0, 20, _ =>
{
    var singletone = Singleton.Instance;
    Console.WriteLine($"Number of creations: {singletone.Count}");
});