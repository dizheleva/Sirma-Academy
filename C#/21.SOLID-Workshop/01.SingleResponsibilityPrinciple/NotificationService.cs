namespace _01.SingleResponsibilityPrinciple
{
    public class NotificationService
    {
        public void NotifyCustomer(Order order)
        {
            // Notify customer
            Console.WriteLine($"Sending email notification to {order.CustomerEmail}...");
        }
    }
}
