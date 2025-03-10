﻿namespace Command.Commands;

class Multiplication : CommandP
{
    public Multiplication(ArithmeticUnit unit, int operand)
    {
        this.unit = unit;
        this.operand = operand;
    }

    public override void Execute()
    {
        unit.Run('*', operand);
    }

    public override void UnExecute()
    {
        unit.Run('/', operand);
    }
}
