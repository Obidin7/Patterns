using ChainOfResponsibility;

var h1 = new ConcreteHandler1();
var h2 = new ConcreteHandler2();

h1.Successor = h2;
h1.HandleRequest(1);
h1.HandleRequest(2);