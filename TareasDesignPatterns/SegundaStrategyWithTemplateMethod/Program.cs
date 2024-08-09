public static class Program
{
    public static void Main()
    {
        var emailNotificationStrategy = new EmailNotificationStrategy();
        var pushNotificationStrategy = new PushNotificationStrategy();

        var formattedEmailNotification = new FormattedNotification(emailNotificationStrategy);
        var loggingPushNotification = new LoggingNotification(pushNotificationStrategy);

        formattedEmailNotification.SendNotification("New message");
        loggingPushNotification.SendNotification("Another message");
    }
}