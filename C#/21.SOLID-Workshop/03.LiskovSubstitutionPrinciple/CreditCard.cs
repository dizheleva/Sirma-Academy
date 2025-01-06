namespace _03.LiskovSubstitutionPrinciple
{
    public class CreditCard : IRefundablePaymentMethod
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }
        public void Refund(double amount)
        {
            Console.WriteLine($"Refunded {amount} to Credit Card.");
        }
    }
}
