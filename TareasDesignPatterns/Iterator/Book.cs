// Clase concreta que representa un libro
class Book
{
    public string Title { get; }

    public Book(string title)
    {
        Title = title;
    }

    public override string ToString()
    {
        return Title;
    }
}