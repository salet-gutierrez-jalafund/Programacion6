// Subclase concreta para preparar café
class Coffee : HotBeverage
{
    protected override void Brew()
    {
        Console.WriteLine("Preparar el café");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Agregar azúcar y leche");
    }
}