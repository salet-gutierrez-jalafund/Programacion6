using System;
using AbstractFactoryComputers.Products.Interfaces;

namespace AbstractFactoryComputers.Products.Windows;

// Implementaciones de ventanas para Windows
public class WindowsWindow : IWindow
{
    public void Render()
    {
        Console.WriteLine("Renderizando ventana de Windows.");
    }
}
