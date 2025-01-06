namespace _06.FindViolations.Task2
{
    public class PushSender : INotificationSender
    {
        public void Notify(string message) => Console.WriteLine($"Push notification sent: {message}");
    }
}
