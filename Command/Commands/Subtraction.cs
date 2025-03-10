namespace Command.Commands;

class Subtraction : CommandP
{
    public Subtraction(ArithmeticUnit unit, int operand)
    {
        this.unit = unit;
        this.operand = operand;
    }

    public override void Execute()
    {
        unit.Run('-', operand);
    }

    public override void UnExecute()
    {
        unit.Run('+', operand);
    }
}
