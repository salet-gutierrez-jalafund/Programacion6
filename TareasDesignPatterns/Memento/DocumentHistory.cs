// Clase Caretaker que gestiona los Mementos
class DocumentHistory
{
    private Stack<DocumentMemento> _history = new Stack<DocumentMemento>();

    // Guardar un nuevo Memento en la historia
    public void Save(Document document)
    {
        _history.Push(document.Save());
    }

    // Deshacer la última operación restaurando el último estado
    public void Undo(Document document)
    {
        if (_history.Count > 0)
        {
            var memento = _history.Pop();
            document.Restore(memento);
        }
        else
        {
            Console.WriteLine("No hay más estados para deshacer.");
        }
    }
}