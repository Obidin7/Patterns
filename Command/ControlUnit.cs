using Command.Commands;

namespace Command;

class ControlUnit
{
    private readonly List<CommandP> _commands = [];
    private int _current = 0;

    public void StoreCommand(CommandP command)
    {
        _commands.Add(command);
    }

    public void ExecuteCommand()
    {
        _commands[_current].Execute();
        _current++;
    }

    public void Undo(int levels)
    {
        for (int i = 0; i < levels; i++)
        {
            if (_current > 0)
            {
                _commands[--_current].UnExecute();
            }
        }
    }

    public void Redo(int levels)
    {
        for (int i = 0; i < levels; i++)
        {
            if (_current < _commands.Count - 1)
            {
                _commands[_current++].Execute();
            }
        }
    }
}
