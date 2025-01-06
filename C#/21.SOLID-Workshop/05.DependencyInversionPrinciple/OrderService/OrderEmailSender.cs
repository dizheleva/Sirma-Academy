namespace _05.DependencyInversionPrinciple.OrderService
{
    public class OrderEmailSender
    {
        public void SendEmail(string email)
        {
            Console.WriteLine($"Sending email to {email}...");
        }
    }
}
