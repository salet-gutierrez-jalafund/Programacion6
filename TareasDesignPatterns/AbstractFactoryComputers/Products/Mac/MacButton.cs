using AbstractFactoryComputers.Products.Interfaces;

namespace AbstractFactoryComputers.Products.Mac;

// Implementaciones de botones para Mac
public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Renderizando botón de Mac.");
    }
}
