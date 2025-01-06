namespace _06.FindViolations.Task2
{
    public class NotificationService
    {
        public void SendNotification(INotificationSender sender, string message)
        {
            sender.Notify(message);
        }
    }
}
