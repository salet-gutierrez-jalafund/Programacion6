using System;

namespace Singleton.AntiPatron.AntiPatronArreglada;

public class NotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Notificación enviada: {message}");
    }
}
