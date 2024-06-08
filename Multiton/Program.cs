using Multiton;

Parallel.For(0, 10, _ =>
{
    var door = new Door();
    var keyLow = UniversalKey.Instance(KeyType.LowSecurity);
    var keyHigh = UniversalKey.Instance(KeyType.HighSecurity);
    Console.WriteLine($"KeyLow - {keyLow.Id}\nKeyHigh - {keyHigh.Id}\nDoor - {door.Id}\n\n");
});