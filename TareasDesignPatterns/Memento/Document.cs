// Clase Originator que representa el documento
class Document
{
    public string Content { get; set; }

    // Guardar el estado actual del documento en un Memento
    public DocumentMemento Save()
    {
        return new DocumentMemento(Content);
    }

    // Restaurar el estado del documento desde un Memento
    public void Restore(DocumentMemento memento)
    {
        Content = memento.Content;
    }
}