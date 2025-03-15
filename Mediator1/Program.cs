using Mediator1;

var mediator = new ConcreteMediator();
var colleague1 = new ConcreteContractor1(mediator);
var colleague2 = new ConcreteContractor2(mediator);

mediator.Colleague1 = colleague1;
mediator.Colleague2 = colleague2;

colleague1.Send("Message 1");
colleague2.Send("Message 2");