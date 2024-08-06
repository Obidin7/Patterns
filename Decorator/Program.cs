using Decorator;

ICar basicCar = new CommonCar();
Console.WriteLine($"\nName: {basicCar.GetName()}");
Console.WriteLine($"Price: {basicCar.GetPrice()}");

ICar carWithAirbag = new Airbag(basicCar);
Console.WriteLine($"\nName: {carWithAirbag.GetName()}");
Console.WriteLine($"Price: {carWithAirbag.GetPrice()}");

ICar carWithLedHeadlights = new LedHeadlights(basicCar);
Console.WriteLine($"\nName: {carWithLedHeadlights.GetName()}");
Console.WriteLine($"Price: {carWithLedHeadlights.GetPrice()}");

ICar carWithAirbagAndLedHeadlights = new LedHeadlights(new Airbag(carWithAirbag));
Console.WriteLine($"\nName: {carWithAirbagAndLedHeadlights.GetName()}");
Console.WriteLine($"Price: {carWithAirbagAndLedHeadlights.GetPrice()}");