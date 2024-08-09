public class LoggingNotification : NotificationTemplate
{
    public LoggingNotification(INotificationStrategy notificationStrategy) : base(notificationStrategy)
    {
    }

    protected override void FormatMessage(string message)
    {
        _message = message;
    }

    protected override void LogNotification(string message)
    {
        Console.WriteLine($"Logging notification with custom format: {message}");
    }
}