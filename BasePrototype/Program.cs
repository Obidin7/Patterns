using BasePrototype;

var car1 = new Car("Toyota");
var car2 = (Car)car1.Copy();
var car3 = car1.CopyWithoutInterface();

Console.WriteLine($"Car1 - Model: {car1.Model}");
Console.WriteLine($"Car2 - Model: {car2.Model}");
Console.WriteLine($"Car3 - Model: {car3.Model}");
