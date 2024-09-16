// Clase de prueba del patrón Template Method
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Preparando té:");
        HotBeverage tea = new Tea();
        tea.PrepareRecipe();

        Console.WriteLine();

        Console.WriteLine("Preparando café:");
        HotBeverage coffee = new Coffee();
        coffee.PrepareRecipe();
    }
}