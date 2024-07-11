using Observer_Push;

var subject = new ConcreteSubject();
subject.Subscribe(new ConcreteObserver(subject));
subject.Subscribe(new ConcreteObserver(subject));
subject.State = "New information";
subject.Notify();