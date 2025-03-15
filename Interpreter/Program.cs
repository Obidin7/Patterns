using Interpreter;

Context context = new Context
{
    Vocabulary = 'h',
    Source = "hhh"
};

var expression = new NonterminalExpression();
expression.Interpret(context);

Console.WriteLine(context.Result);