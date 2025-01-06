namespace _05.DependencyInversionPrinciple.OrderService
{
    public class PayPal : IPaymentMethod
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }
    }
}
