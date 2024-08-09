public class FormattedNotification : NotificationTemplate
{
    public FormattedNotification(INotificationStrategy notificationStrategy) : base(notificationStrategy)
    {
    }

    protected override void FormatMessage(string message)
    {
        _message = $"[{DateTime.Now}] {message}";
    }
}