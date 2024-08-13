using CommandRestauranteMenu.src.Entities;

namespace CommandRestauranteMenu.src.Strategies.Interfaces;

public interface IOrderStrategy
{
    void Execute(Order order);
}
