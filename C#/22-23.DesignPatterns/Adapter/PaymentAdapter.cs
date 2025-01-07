internal class PaymentAdapter : IPayment
{
    private OldPaymentSystem oldPaymentSystem;

    public PaymentAdapter(OldPaymentSystem oldPaymentSystem)
    {
        this.oldPaymentSystem = oldPaymentSystem;
    }

    public void ProcessPayment(string account, decimal amount)
    {
        string currency = "USD";
        oldPaymentSystem.MakePayment(account, currency, (double)amount);
    }
}