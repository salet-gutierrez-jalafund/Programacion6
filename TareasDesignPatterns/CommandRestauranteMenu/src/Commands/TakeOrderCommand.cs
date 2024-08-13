using CommandRestauranteMenu.src.Commands.Interfaces;
using CommandRestauranteMenu.src.Receivers;

namespace CommandRestauranteMenu.src.Commands;

public class TakeOrderCommand : ICommand
{
    private readonly OrderReceiver _orderReceiver;

    public TakeOrderCommand(OrderReceiver orderReceiver)
    {
        _orderReceiver = orderReceiver;
    }

    public void Execute()
    {
        _orderReceiver.TakeOrder();
    }
}
