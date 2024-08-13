using CommandRestauranteMenu.src.Entities;
using CommandRestauranteMenu.src.Strategies.Interfaces;

namespace CommandRestauranteMenu.src.Strategies;

public class SimpleCalculateTotalStrategy : ICalculateTotalStrategy
{
    public decimal CalculateTotal(List<Order> orders)
    {
        return orders.Sum(order => order.GetTotal());
    }
}
