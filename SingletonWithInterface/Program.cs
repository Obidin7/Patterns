using SingletonWithInterface;

Parallel.For(0, 10, _ =>
{
    var door = new Door();
    var key = UniversalKey.Instance;
    Console.WriteLine($"Key - {key.Id}\nDoor - {door.Id}\n\n");
});