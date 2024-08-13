using Spectre.Console;
using CommandRestauranteMenu.src.Receivers;
using CommandRestauranteMenu.src.Entities;
using CommandRestauranteMenu.src.Strategies.Interfaces;

namespace CommandRestauranteMenu.src.Strategies;

public class SelectItemsStrategy : IOrderStrategy
{
    private readonly MenuReceiver _menuReceiver;

    public SelectItemsStrategy(MenuReceiver menuReceiver)
    {
        _menuReceiver = menuReceiver;
    }

    public void Execute(Order order)
    {
        var menuItems = _menuReceiver.GetMenuItems();
        var selectedItems = AnsiConsole.Prompt(
            new MultiSelectionPrompt<MenuItem>()
                .Title("Selecciona los ítems que deseas ordenar:")
                .PageSize(10)
                .MoreChoicesText("[grey](Mueve hacia arriba y hacia abajo para ver más)[/]")
                .InstructionsText("[grey](Presiona [blue]<espacio>[/] para seleccionar, [green]<enter>[/] para confirmar)[/]")
                .AddChoices(menuItems));

        foreach (var item in selectedItems)
        {
            order.AddItem(item);
        }
    }
}
