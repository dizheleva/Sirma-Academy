namespace _05.DependencyInversionPrinciple.OrderService
{
    public class BankTransfer : IPaymentMethod
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Bank Transfer.");
        }
    }
}
