using Observer_Bidirectional;

var car = new Car { Name = "Audi" };
var appWindow = new AppWindow { CarName = "Audi" };

car.PropertyChanged += (sender, eventArgs) =>
{
    if (eventArgs.PropertyName == "Name")
    {
        Console.WriteLine("Name changed in Car");
        appWindow.CarName = car.Name;
    }
};

appWindow.PropertyChanged += (sender, eventArgs) =>
{
    if (eventArgs.PropertyName == "CarName")
    {
        Console.WriteLine("Name changed in AppWindow");
        car.Name = appWindow.CarName;
    }
};

using var binding = new BidirectionalBinding(
  car,
  () => car.Name,
  appWindow,
  () => appWindow.CarName);

car.Name = "BMW";
Console.WriteLine(car);
Console.WriteLine(appWindow);

appWindow.CarName = "Tesla";
Console.WriteLine(car);
Console.WriteLine(appWindow);