using CommandRestauranteMenu.src.Entities;
using CommandRestauranteMenu.src.Receivers;
using CommandRestauranteMenu.src.Repositories.Interfaces;
using CommandRestauranteMenu.src.Services.Interfaces;
using CommandRestauranteMenu.src.Strategies;

namespace CommandRestauranteMenu.src.Services.Concrets;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly MenuReceiver _menuReceiver;

    public OrderService(IOrderRepository orderRepository, MenuReceiver menuReceiver)
    {
        _orderRepository = orderRepository;
        _menuReceiver = menuReceiver;
    }

    public void CreateOrder()
    {
        var order = new Order();

        var selectItemsStrategy = new SelectItemsStrategy(_menuReceiver);
        selectItemsStrategy.Execute(order);

        var displayOrderSummaryStrategy = new DisplayOrderSummaryStrategy();
        displayOrderSummaryStrategy.Execute(order);

        var confirmOrderStrategy = new ConfirmOrderStrategy(_orderRepository);
        confirmOrderStrategy.Execute(order);
    }
}
