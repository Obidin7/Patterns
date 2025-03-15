namespace Interpreter;

public class NonterminalExpression : AbstractExpression
{
    private AbstractExpression _nonterminalExpression;
    private AbstractExpression _terminalExpression;

    public override void Interpret(Context context)
    {
        if (context.Position < context.Source.Length)
        {
            _terminalExpression = new TerminalExpression();
            _terminalExpression.Interpret(context);
            context.Position++;

            if (context.Result)
            {
                _nonterminalExpression = new NonterminalExpression();
                _nonterminalExpression.Interpret(context);
            }
        }
    }
}
