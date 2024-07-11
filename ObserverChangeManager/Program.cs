using ObserverChangeManager;

ChangeManager manager = SimpleChangeManager.Singleton;

//manager = DAGChangeManager.Singleton;

var subject1 = new Subject("Subject1", manager);
var subject2 = new Subject("Subject2", manager);

var commonObserver = new Observer("CommonObserver");

manager.Register(subject1, commonObserver);
manager.Register(subject1, new Observer("Observer1"));
manager.Register(subject1, new Observer("Observer2"));

manager.Register(subject2, commonObserver);
manager.Register(subject2, new Observer("Observer3"));

subject1.Notify();