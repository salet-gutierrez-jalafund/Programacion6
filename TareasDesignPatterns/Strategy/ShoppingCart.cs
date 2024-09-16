// Clase Context que utiliza una estrategia de descuento
class ShoppingCart
{
    private IDiscountStrategy _discountStrategy;

    public ShoppingCart(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public decimal CalculateFinalPrice(decimal price)
    {
        return _discountStrategy.ApplyDiscount(price);
    }
}