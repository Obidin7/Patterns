using Observer_MemoryLeak;

var car = new Car();
var carLog = new Carlog(car);
var carLogRef = new WeakReference(carLog);
var carRef = new WeakReference(car);

car.Crash();

Console.WriteLine("Setting carLog to null");
car = null;

FireGC();
Console.WriteLine($"CarLog alive after setting window to null? {carLogRef.IsAlive}");
Console.WriteLine($"Car alive after setting window to null? {carRef.IsAlive}");

//car.Crash();

Console.WriteLine("Setting car to null");
carLog = null;

FireGC();
Console.WriteLine($"CarLog alive after setting button to null? {carLogRef.IsAlive}");
Console.WriteLine($"Car alive after setting button to null? {carRef.IsAlive}");
        

static void FireGC()
{
    GC.Collect();
    GC.WaitForPendingFinalizers();
    GC.Collect();
    Console.WriteLine("GC is done!");
}