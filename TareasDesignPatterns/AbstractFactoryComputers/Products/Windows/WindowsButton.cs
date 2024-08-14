using AbstractFactoryComputers.Products.Interfaces;

namespace AbstractFactoryComputers.Products.Windows;

// Implementaciones de botones para Windows
public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Renderizando botón de Windows.");
    }
}
