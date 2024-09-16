// Manejador concreto: Representante de Servicio al Cliente
class CustomerServiceRep : ComplaintHandler
{
    public override void HandleComplaint(string complaint, int severity)
    {
        if (severity <= 2)
        {
            Console.WriteLine($"Representante de Servicio al Cliente maneja la queja: {complaint}");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleComplaint(complaint, severity);
        }
    }
}