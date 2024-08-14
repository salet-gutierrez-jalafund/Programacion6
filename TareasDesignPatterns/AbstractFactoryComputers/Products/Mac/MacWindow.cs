using AbstractFactoryComputers.Products.Interfaces;

namespace AbstractFactoryComputers.Products.Mac;

// Implementaciones de ventanas para Mac
public class MacWindow : IWindow
{
    public void Render()
    {
        Console.WriteLine("Renderizando ventana de Mac.");
    }
}
