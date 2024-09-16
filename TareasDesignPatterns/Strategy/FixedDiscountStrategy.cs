// Estrategia concreta: descuento fijo
class FixedDiscountStrategy : IDiscountStrategy
{
    private readonly decimal _discountAmount;
    
    public FixedDiscountStrategy(decimal discountAmount)
    {
        _discountAmount = discountAmount;
    }

    public decimal ApplyDiscount(decimal price)
    {
        return price - _discountAmount;
    }
}