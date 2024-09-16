// Manejador concreto: Supervisor
class Supervisor : ComplaintHandler
{
    public override void HandleComplaint(string complaint, int severity)
    {
        if (severity > 2 && severity <= 4)
        {
            Console.WriteLine($"Supervisor maneja la queja: {complaint}");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleComplaint(complaint, severity);
        }
    }
}