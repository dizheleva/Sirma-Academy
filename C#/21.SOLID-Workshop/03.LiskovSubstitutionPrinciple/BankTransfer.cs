namespace _03.LiskovSubstitutionPrinciple
{
    public class BankTransfer : IPaymentMethod
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Bank Transfer.");
        }
    }
}
