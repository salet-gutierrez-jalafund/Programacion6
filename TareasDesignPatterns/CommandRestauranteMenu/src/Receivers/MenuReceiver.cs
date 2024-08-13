using CommandRestauranteMenu.src.Entities;
using Spectre.Console;

namespace CommandRestauranteMenu.src.Receivers;

public class MenuReceiver
{
    private List<MenuItem> _menuItems = new List<MenuItem>
        {
            new MenuItem("Pizza", 10.00m),
            new MenuItem("Pasta", 8.00m),
            new MenuItem("Ensalada", 5.00m)
        };

    public void ListMenu()
    {
        var table = new Table();
        table.AddColumn("Plato");
        table.AddColumn("Precio");

        foreach (var item in _menuItems)
        {
            table.AddRow(item.Name, $"${item.Price}");
        }

        AnsiConsole.Write(table);
    }

    public List<MenuItem> GetMenuItems()
    {
        return _menuItems;
    }
}
