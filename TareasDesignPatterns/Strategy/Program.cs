// Clase de prueba del patrón Strategy
class Program
{
    static void Main(string[] args)
    {
        decimal originalPrice = 100m;

        // Usar la estrategia de "sin descuento"
        ShoppingCart cart = new ShoppingCart(new NoDiscountStrategy());
        Console.WriteLine($"Precio original: {originalPrice}, Precio final: {cart.CalculateFinalPrice(originalPrice)}");

        // Cambiar a la estrategia de "descuento por porcentaje"
        cart.SetDiscountStrategy(new PercentageDiscountStrategy(10));  // 10% de descuento
        Console.WriteLine($"Precio original: {originalPrice}, Precio final con 10% descuento: {cart.CalculateFinalPrice(originalPrice)}");

        // Cambiar a la estrategia de "descuento fijo"
        cart.SetDiscountStrategy(new FixedDiscountStrategy(15));  // $15 de descuento
        Console.WriteLine($"Precio original: {originalPrice}, Precio final con $15 descuento: {cart.CalculateFinalPrice(originalPrice)}");
    }
}