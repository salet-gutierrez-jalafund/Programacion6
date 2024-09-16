// Iterador concreto que implementa IIterator para una lista de libros
class BookIterator : IIterator<Book>
{
    private List<Book> _books;
    private int _position = -1;  // Comienza antes del primer elemento

    public BookIterator(List<Book> books)
    {
        _books = books;
    }

    // Obtener el libro actual
    public Book Current => _books[_position];

    // Moverse al siguiente libro en la colección
    public bool MoveNext()
    {
        if (_position < _books.Count - 1)
        {
            _position++;
            return true;
        }
        return false;
    }

    // Reiniciar el iterador a la posición inicial
    public void Reset()
    {
        _position = -1;
    }
}