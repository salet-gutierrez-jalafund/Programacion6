// Colección concreta de libros que implementa IBookCollection
class Library : IBookCollection
{
    private List<Book> _books = new List<Book>();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public IIterator<Book> CreateIterator()
    {
        return new BookIterator(_books);
    }
}