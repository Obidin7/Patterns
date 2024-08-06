using AbstractFactory;

var factory = new DefaultVehicleFactory();
ProcessVehicle(factory);

Console.WriteLine("\n------------------------------------------------------------\n");

var colorFactory = new ColorVehicleFactory();
ProcessVehicle(colorFactory);

static void ProcessVehicle(ICommonFactory factory)
{
    var car = factory.CreateCar();
    var boat = factory.CreateBoat();

    car.CreateSportCar();
    car.CreateEconomyCar();
    boat.CreateMotorBoat();
    boat.CreateSailBoat();
}