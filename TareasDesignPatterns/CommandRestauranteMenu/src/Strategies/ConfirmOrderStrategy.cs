using Spectre.Console;
using CommandRestauranteMenu.src.Entities;
using CommandRestauranteMenu.src.Repositories.Interfaces;
using CommandRestauranteMenu.src.Strategies.Interfaces;

namespace CommandRestauranteMenu.src.Strategies;

public class ConfirmOrderStrategy : IOrderStrategy
{
    private readonly IOrderRepository _orderRepository;

    public ConfirmOrderStrategy(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public void Execute(Order order)
    {
        var confirm = AnsiConsole.Confirm("¿Estás seguro de tu pedido?");

        if (confirm)
        {
            _orderRepository.SaveOrder(order);
            AnsiConsole.MarkupLine("[green]Orden guardada correctamente.[/]");
        }
        else
        {
            AnsiConsole.MarkupLine("[red]Orden cancelada.[/]");
        }
    }
}
