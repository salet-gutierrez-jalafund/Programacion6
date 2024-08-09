public class EmailNotificationStrategy : INotificationStrategy
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}