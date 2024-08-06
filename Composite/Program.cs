using Composite;

var engine = new Part("Engine");
var audio = new Part("Audio");
var steeringWheel = new Part("Steering Wheel");
var headlights = new Part("Headlights");

var frontComponent = new Assembly("Front Component");
frontComponent.AddPart(steeringWheel);
frontComponent.AddPart(headlights);

var car = new Assembly("Car");
car.AddPart(engine);
car.AddPart(audio);
car.AddPart(frontComponent);

Console.WriteLine("Car Assembly:");
car.GetName();