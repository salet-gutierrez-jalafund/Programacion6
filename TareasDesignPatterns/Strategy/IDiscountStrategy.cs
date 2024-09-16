// Interfaz Strategy que define el contrato para las estrategias de descuento
interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal price);
}