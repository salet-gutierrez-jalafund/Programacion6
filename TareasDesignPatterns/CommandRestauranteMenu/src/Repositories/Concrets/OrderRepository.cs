using CommandRestauranteMenu.src.Entities;
using CommandRestauranteMenu.src.Repositories.Interfaces;

namespace CommandRestauranteMenu.src.Repositories.Concrets;

public class OrderRepository : IOrderRepository
{
    private readonly List<Order> _orders = new();

    public void SaveOrder(Order order)
    {
        _orders.Add(order);
    }

    public List<Order> GetOrders()
    {
        return _orders;
    }
}
