namespace _06.FindViolations.Task6
{
    public class PaymentProcessor
    {
        public void ProcessPayment(IPaymentMethod paymentType, double amount)
        {
            Console.WriteLine($"Processing payment for {amount}...");
            paymentType.Pay(amount);
        }
    }
}
