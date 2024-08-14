using AbstractFactoryComputers.Factories.Interfaces;
using AbstractFactoryComputers.Products.Interfaces;
using AbstractFactoryComputers.Products.Windows;

namespace AbstractFactoryComputers.Factories;

// Fábrica concreta para Windows
public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public IWindow CreateWindow()
    {
        return new WindowsWindow();
    }
}
