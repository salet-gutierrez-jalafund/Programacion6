using AbstractFactoryComputers.Factories.Interfaces;
using AbstractFactoryComputers.Products.Interfaces;
using AbstractFactoryComputers.Products.Mac;

namespace AbstractFactoryComputers.Factories;

// Fábrica concreta para Mac
public class MacFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public IWindow CreateWindow()
    {
        return new MacWindow();
    }
}
