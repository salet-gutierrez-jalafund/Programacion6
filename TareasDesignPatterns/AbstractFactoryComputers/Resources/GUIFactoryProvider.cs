using System;
using AbstractFactoryComputers.Factories;
using AbstractFactoryComputers.Factories.Interfaces;

namespace AbstractFactoryComputers.Resources;

// Clase para seleccionar la fábrica concreta usando un Dictionary
public static class GUIFactoryProvider
{
    // Diccionario que mapea el tipo de sistema operativo a la fábrica correspondiente
    private static readonly Dictionary<string, IGUIFactory> Factories = new Dictionary<string, IGUIFactory>
    {
        { "Windows", new WindowsFactory() },
        { "Mac", new MacFactory() }
    };

    // Método para obtener la fábrica concreta en función del tipo de sistema operativo
    public static IGUIFactory CreateFactory(string osType)
    {
        if (Factories.TryGetValue(osType, out var factory))
        {
            return factory;
        }
        else
        {
            throw new ArgumentException("Tipo de sistema operativo no soportado.");
        }
    }
}
