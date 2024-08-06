using Observer;

var subject = new ConcreteSubject();
subject.Subscribe(new ConcreteObserver(subject));
subject.Subscribe(new ConcreteObserver(subject));
subject.State = "New info";
subject.Notify();