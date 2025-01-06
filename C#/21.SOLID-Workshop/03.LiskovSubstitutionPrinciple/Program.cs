using _03.LiskovSubstitutionPrinciple;

internal class Program
{
    private static void Main(string[] args)
    {
        IRefundablePaymentMethod creditCard = new CreditCard();
        IPaymentMethod bankTransfer = new BankTransfer();

        var paymentProcessor = new PaymentProcessor();

        paymentProcessor.ProcessPayment(bankTransfer, 100);
        paymentProcessor.ProcessRefund(creditCard, 50);
    }
}