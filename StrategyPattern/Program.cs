using StrategyPattern;

Context context;
context = new Context(new FirstStrategy());
context.ContextInterface();
context = new Context(new SecondStrategy());
context.ContextInterface();