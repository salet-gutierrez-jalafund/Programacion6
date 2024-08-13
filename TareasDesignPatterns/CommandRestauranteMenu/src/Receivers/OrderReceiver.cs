using CommandRestauranteMenu.src.Services.Interfaces;

namespace CommandRestauranteMenu.src.Receivers;

public class OrderReceiver
{
    private readonly IOrderService _orderService;

    public OrderReceiver(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public void TakeOrder()
    {
        _orderService.CreateOrder();
    }
}
