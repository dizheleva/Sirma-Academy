namespace _06.FindViolations.Task2
{
    public class EmailSender : INotificationSender
    {
        public void Notify(string message) => Console.WriteLine($"Email sent: {message}");
    }
}
