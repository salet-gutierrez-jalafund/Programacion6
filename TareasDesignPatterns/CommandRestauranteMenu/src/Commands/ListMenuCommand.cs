using CommandRestauranteMenu.src.Commands.Interfaces;
using CommandRestauranteMenu.src.Receivers;

namespace CommandRestauranteMenu.src.Commands;

public class ListMenuCommand : ICommand
{
    private readonly MenuReceiver _menuReceiver;

    public ListMenuCommand(MenuReceiver menuReceiver)
    {
        _menuReceiver = menuReceiver;
    }

    public void Execute()
    {
        _menuReceiver.ListMenu();
    }
}
