public class PushNotificationStrategy : INotificationStrategy
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending push notification: {message}");
    }
}