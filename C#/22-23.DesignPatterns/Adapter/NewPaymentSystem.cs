public class NewPaymentSystem : IPayment
{
    public void ProcessPayment(string account, decimal amount) 
        => Console.WriteLine($"Payment of ${amount} processed for account {account}.");
}