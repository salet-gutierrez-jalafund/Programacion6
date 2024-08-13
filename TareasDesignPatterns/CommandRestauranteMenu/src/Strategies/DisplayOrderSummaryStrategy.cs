using Spectre.Console;
using CommandRestauranteMenu.src.Entities;
using CommandRestauranteMenu.src.Strategies.Interfaces;

namespace CommandRestauranteMenu.src.Strategies;

public class DisplayOrderSummaryStrategy : IOrderStrategy
{
    public void Execute(Order order)
    {
        var table = new Table();
        table.AddColumn("Plato");
        table.AddColumn("Precio");

        foreach (var item in order.Items)
        {
            table.AddRow(item.Name, $"${item.Price}");
        }

        AnsiConsole.Write(new Panel(table)
            .Header("Resumen de la Orden")
            .Border(BoxBorder.Rounded)
            .BorderColor(Color.Green));
    }
}
