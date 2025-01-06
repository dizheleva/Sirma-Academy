namespace _06.FindViolations.Task2
{
    public class SMSSender : INotificationSender
    {
        public void Notify(string message) => Console.WriteLine($"SMS sent: {message}");
    }
}
