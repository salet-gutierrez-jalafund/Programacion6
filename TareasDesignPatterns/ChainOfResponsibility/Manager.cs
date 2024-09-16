// Manejador concreto: Gerente
class Manager : ComplaintHandler
{
    public override void HandleComplaint(string complaint, int severity)
    {
        if (severity > 4)
        {
            Console.WriteLine($"Gerente maneja la queja: {complaint}");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleComplaint(complaint, severity);
        }
    }
}