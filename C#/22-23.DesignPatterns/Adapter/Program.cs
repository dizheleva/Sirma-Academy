internal class Program
{
    private static void Main(string[] args)
    {
        IPayment newPaymentSystem = new NewPaymentSystem();
        newPaymentSystem.ProcessPayment("user123", 150.75m);

        Console.WriteLine();

        OldPaymentSystem oldPaymentSystem = new OldPaymentSystem();
        IPayment adapter = new PaymentAdapter(oldPaymentSystem);
        adapter.ProcessPayment("user456", 250.50m);
    }
}