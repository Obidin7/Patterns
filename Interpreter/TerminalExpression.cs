﻿namespace Interpreter;

public class TerminalExpression : AbstractExpression
{
    public override void Interpret(Context context)
    {
        context.Result = context.Source[context.Position] == context.Vocabulary;
    }
}
