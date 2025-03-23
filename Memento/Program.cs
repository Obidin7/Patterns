using Memento;

var originator = new Originator
{
    State = "On"
};

Console.WriteLine(originator.State);

var caretaker = new Caretaker
{
    Memento = originator.CreateMemento()
};

originator.State = "Off";

Console.WriteLine(originator.State);

originator.SetMemento(caretaker.Memento as IWideInterface);

Console.WriteLine(originator.State);