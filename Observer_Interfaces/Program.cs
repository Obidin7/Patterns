using Observer_Interfaces;

var person = new Person();

person.PropertyChanged += (sender, eventArgs) =>
{
    Console.WriteLine($"{eventArgs.PropertyName} has changed");
};

person.Age = 15;
person.AlcoholAllowed = true;