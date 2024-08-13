using CommandRestauranteMenu.src.Repositories.Interfaces;
using CommandRestauranteMenu.src.Services.Interfaces;
using CommandRestauranteMenu.src.Strategies.Interfaces;

namespace CommandRestauranteMenu.src.Services.Concrets;

public class BillService : IBillService
{
    private readonly IOrderRepository _orderRepository;
    private readonly ICalculateTotalStrategy _calculateTotalStrategy;

    public BillService(IOrderRepository orderRepository, ICalculateTotalStrategy calculateTotalStrategy)
    {
        _orderRepository = orderRepository;
        _calculateTotalStrategy = calculateTotalStrategy;
    }

    public decimal CalculateTotal()
    {
        var orders = _orderRepository.GetOrders();
        return _calculateTotalStrategy.CalculateTotal(orders);
    }
}
