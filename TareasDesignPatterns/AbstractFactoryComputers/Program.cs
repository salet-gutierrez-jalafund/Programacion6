using AbstractFactoryComputers.Factories.Interfaces;
using AbstractFactoryComputers.Products.Interfaces;
using AbstractFactoryComputers.Resources;


/// <summary>
/// El patrón Abstract Factory es un patrón de diseño creacional que 
/// proporciona una interfaz para crear familias de objetos relacionados 
/// o dependientes sin especificar sus clases concretas.
/// 
/// Componentes del Patrón Abstract Factory
/// 
/// Abstract Factory: Define una interfaz que declara un conjunto de métodos 
/// para crear cada uno de los productos abstractos.
/// Concrete Factory: Implementa la interfaz Abstract Factory y crea objetos 
/// de productos concretos.
/// Abstract Product: Declara una interfaz para un tipo de producto.
/// Concrete Product: Implementa la interfaz del Abstract Product y define un 
/// objeto que será creado por la Concrete Factory correspondiente.
/// Client: Sólo utiliza las interfaces declaradas por Abstract Factory y Abstract 
/// Product. El cliente no conoce las clases concretas de los productos que está utilizando.
/// 
/// Cuándo Utilizar
/// - Necesidad de crear productos relacionados
/// - Independencia de las implementaciones concretas
/// - Variaciones de productos
/// - Cambio de familias de productos en tiempo de ejecución
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Seleccionamos la fábrica a usar en función del sistema operativo
        string osTypeWindows = "Windows"; // Cambiar a "Mac" para probar con MacFactory

        // Seleccionamos la fábrica a usar
        IGUIFactory factoryWindows = GUIFactoryProvider.CreateFactory(osTypeWindows);

        // Creamos los productos usando la fábrica
        IButton button = factoryWindows.CreateButton();
        IWindow window = factoryWindows.CreateWindow();

        // Usamos los productos
        button.Render();
        window.Render();




        string osTypeMac = "Mac"; // Cambiar a "Mac" para probar con MacFactory

        // Seleccionamos la fábrica a usar
        IGUIFactory factoryMac = GUIFactoryProvider.CreateFactory(osTypeMac);

        // Creamos los productos usando la fábrica
        IButton buttonMac = factoryMac.CreateButton();
        IWindow windowMac = factoryMac.CreateWindow();

        // Usamos los productos
        buttonMac.Render();
        windowMac.Render();
    }
}
