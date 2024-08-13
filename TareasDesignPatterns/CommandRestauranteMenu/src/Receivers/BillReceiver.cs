using CommandRestauranteMenu.src.Services.Interfaces;
using Spectre.Console;

namespace CommandRestauranteMenu.src.Receivers;

public class BillReceiver
{
    private readonly IBillService _billService;

    public BillReceiver(IBillService billService)
    {
        _billService = billService;
    }

    public void GenerateBill()
    {
        var total = _billService.CalculateTotal();
        AnsiConsole.MarkupLine("[green]Generando cuenta...[/]");
        AnsiConsole.MarkupLine($"[yellow]Total a pagar: ${total}[/]");
    }
}
