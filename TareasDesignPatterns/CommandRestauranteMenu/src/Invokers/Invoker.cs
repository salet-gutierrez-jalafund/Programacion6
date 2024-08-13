using CommandRestauranteMenu.src.Commands.Interfaces;

namespace CommandRestauranteMenu.src.Invokers;

public class Invoker
{
    private readonly Dictionary<string, ICommand> _commands;

    public Invoker()
    {
        _commands = new Dictionary<string, ICommand>();
    }

    public void SetCommand(string commandName, ICommand command)
    {
        _commands[commandName] = command;
    }

    public void ExecuteCommand(string commandName)
    {
        if (_commands.ContainsKey(commandName))
        {
            _commands[commandName].Execute();
        }
    }
}
