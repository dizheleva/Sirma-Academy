namespace _03.LiskovSubstitutionPrinciple
{
    public class PaymentProcessor
    {
        public void ProcessPayment(IPaymentMethod paymentMethod, double amount)
        {
            paymentMethod.Pay(amount);
        }

        public void ProcessRefund(IRefundablePaymentMethod paymentMethod, double amount)
        {
            paymentMethod.Refund(amount);
        }
    }
}
