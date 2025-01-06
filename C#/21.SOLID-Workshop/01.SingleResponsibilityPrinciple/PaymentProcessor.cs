namespace _01.SingleResponsibilityPrinciple
{
    public class PaymentProcessor
    {
        public void ProcessPayment(Order order)
        {
            Console.WriteLine($"Processing payment for {order.TotalAmount}...");
        }
    }
}
