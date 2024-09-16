// Clase Memento que almacena el estado del documento
class DocumentMemento
{
    public string Content { get; }

    public DocumentMemento(string content)
    {
        Content = content;
    }
}