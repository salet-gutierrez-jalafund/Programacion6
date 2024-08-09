public abstract class NotificationTemplate
{
    protected INotificationStrategy _notificationStrategy;
    protected string _message;

    public NotificationTemplate(INotificationStrategy notificationStrategy)
    {
        _notificationStrategy = notificationStrategy;
    }

    public void SendNotification(string message)
    {
        FormatMessage(message);
        LogNotification(_message);
        _notificationStrategy.SendNotification(_message);
    }

    protected abstract void FormatMessage(string message);

    protected virtual void LogNotification(string message)
    {
        Console.WriteLine($"Logging notification: {message}");
    }
}