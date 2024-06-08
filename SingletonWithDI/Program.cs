using Microsoft.Extensions.DependencyInjection;
using SingletonWithDI;

var services = new ServiceCollection();

services.AddSingleton<UniversalKey>();
services.AddTransient<Door>();

var serviceProvider = services.BuildServiceProvider();

Parallel.For(0, 10, _ =>
{
    var door = serviceProvider.GetRequiredService<Door>();
    var key = serviceProvider.GetRequiredService<UniversalKey>();
    Console.WriteLine($"Key - {key.Id}\nDoor - {door.Id}\n\n");
});
