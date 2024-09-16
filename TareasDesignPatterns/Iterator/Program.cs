// Clase de prueba del patrón Iterator
class Program
{
    static void Main(string[] args)
    {
        // Crear una biblioteca y agregar algunos libros
        var library = new Library();
        library.AddBook(new Book("Clean Code"));
        library.AddBook(new Book("The Pragmatic Programmer"));
        library.AddBook(new Book("Design Patterns"));

        // Obtener un iterador para recorrer los libros
        var iterator = library.CreateIterator();

        // Recorrer los libros usando el iterador
        Console.WriteLine("Libros en la biblioteca:");
        while (iterator.MoveNext())
        {
            var book = iterator.Current;
            Console.WriteLine(book);
        }
    }
}