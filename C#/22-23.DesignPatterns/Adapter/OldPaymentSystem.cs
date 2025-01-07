public class OldPaymentSystem
{
    public void MakePayment(string userId, string currency, double amount)
    {
        Console.WriteLine($"Old system: Payment of {amount}{currency} made to customer {userId}.");
    }
}