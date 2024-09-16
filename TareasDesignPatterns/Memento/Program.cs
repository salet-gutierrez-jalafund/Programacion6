// Clase de prueba del patrón Memento
class Program
{
    static void Main(string[] args)
    {
        var document = new Document();
        var history = new DocumentHistory();

        // Escribir contenido en el documento
        document.Content = "Primera versión del texto.";
        history.Save(document);  // Guardar el estado
        Console.WriteLine($"Contenido actual: {document.Content}");

        // Escribir más contenido
        document.Content = "Segunda versión del texto.";
        history.Save(document);  // Guardar el estado
        Console.WriteLine($"Contenido actual: {document.Content}");

        // Deshacer la última operación
        history.Undo(document);
        Console.WriteLine($"Después de deshacer: {document.Content}");

        // Deshacer nuevamente
        history.Undo(document);
        Console.WriteLine($"Después de deshacer otra vez: {document.Content}");
    }
}