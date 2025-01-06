namespace _05.DependencyInversionPrinciple.ReportGenerator
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(string recipient, string content)
        {
            Console.WriteLine($"Sending email to {recipient}...");
        }
    }
}
