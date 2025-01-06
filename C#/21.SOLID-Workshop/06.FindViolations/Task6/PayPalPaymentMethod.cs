namespace _06.FindViolations.Task6
{
    public class PayPalPaymentMethod : IPaymentMethod
    {
        public void Pay(double amount) => Console.WriteLine("Processing PayPal payment...");
    }
}
