using CommandRestauranteMenu.src.Entities;

namespace CommandRestauranteMenu.src.Repositories.Interfaces;

public interface IOrderRepository
{
    void SaveOrder(Order order);
    
    List<Order> GetOrders();
}
