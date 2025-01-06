namespace _05.DependencyInversionPrinciple.OrderService
{
    public class PaymentProcessor
    {
        public void ProcessPayment(Order order)
        {
            Console.WriteLine($"Processing payment for {order.TotalAmount}...");
            order.PaymentMethod.Pay(order.TotalAmount);
        }
    }
}
