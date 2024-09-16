// Subclase concreta para preparar té
class Tea : HotBeverage
{
    protected override void Brew()
    {
        Console.WriteLine("Preparar el té");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Agregar limón");
    }
}