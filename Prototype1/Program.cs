using Prototype1;

var car1 = new Car("Toyota", "Black");
var car2 = car1.Copy();
car2.Color = "Red";
Console.WriteLine("-------------------------Shallow Copy----------------------------------------------");
Console.WriteLine($"Car1 - Model: {car1.Model}, Color: {car1.Color}");
Console.WriteLine($"Car2 - Model: {car2.Model}, Color: {car2.Color}");
Console.WriteLine("-------------------------Problem----------------------------------------------");

var boat1 = new Boat("Yamaha", "White");
var boat2 = boat1.Copy();
var boat3 = boat1.DeepCopy();
var boat4 = boat1.SereliazationCopy();
boat2.Information.Color = "Blue";
boat3.Information.Color = "Green";
boat4.Information.Color = "Yellow";

Console.WriteLine($"Boat1 - Model: {boat1.Information.Model}, Color: {boat1.Information.Color}");
Console.WriteLine($"Boat2 - Model: {boat2.Information.Model}, Color: {boat2.Information.Color}");
Console.WriteLine($"Boat3(DeepCopy) - Model: {boat3.Information.Model}, Color: {boat3.Information.Color}");
Console.WriteLine($"Boat4(SereliazationCopy) - Model: {boat4.Information.Model}, Color: {boat4.Information.Color}");

Console.WriteLine("-------------------------Clone----------------------------------------------");
var car3 = (Car)car1.Clone();
car3.Color = "Green";
Console.WriteLine($"Car1 - Model: {car1.Model}, Color: {car1.Color}");
Console.WriteLine($"Car3 - Model: {car3.Model}, Color: {car3.Color}");
