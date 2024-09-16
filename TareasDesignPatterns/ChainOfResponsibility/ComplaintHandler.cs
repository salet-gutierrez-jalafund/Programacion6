// Clase abstracta que define el manejador
abstract class ComplaintHandler
{
    protected ComplaintHandler _nextHandler;

    // Método para establecer el siguiente manejador en la cadena
    public void SetNextHandler(ComplaintHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    // Método abstracto para procesar la queja
    public abstract void HandleComplaint(string complaint, int severity);
}