namespace _06.FindViolations.Task6
{
    public class CreditPaymentMethod : IPaymentMethod
    {
        public void Pay(double amount) => Console.WriteLine("Processing credit card payment...");
    }
}
