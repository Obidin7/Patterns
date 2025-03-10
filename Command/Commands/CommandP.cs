namespace Command.Commands;

abstract class CommandP
{
    protected ArithmeticUnit unit;
    protected int operand;

    public abstract void Execute();
    public abstract void UnExecute();
}
