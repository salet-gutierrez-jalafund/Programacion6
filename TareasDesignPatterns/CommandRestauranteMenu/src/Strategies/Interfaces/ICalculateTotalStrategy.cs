using CommandRestauranteMenu.src.Entities;

namespace CommandRestauranteMenu.src.Strategies.Interfaces;

public interface ICalculateTotalStrategy
{
    decimal CalculateTotal(List<Order> orders);
}
