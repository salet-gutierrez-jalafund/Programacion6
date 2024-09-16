// Interfaz para la colección que proporciona un iterador
interface IBookCollection
{
    IIterator<Book> CreateIterator();  // Método para crear el iterador
}