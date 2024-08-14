using AbstractFactoryComputers.Products.Interfaces;

namespace AbstractFactoryComputers.Factories.Interfaces;

// Interfaz de fábrica abstracta
public interface IGUIFactory
{
    IButton CreateButton();
    IWindow CreateWindow();
}
