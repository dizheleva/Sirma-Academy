using _01.SingleResponsibilityPrinciple;

internal class Program
{
    private static void Main(string[] args)
    {
        var order = new Order
        {
            Items = ["book", "game", "headphones"],
            TotalAmount = 100,
            CustomerEmail = "customer@mail.com"
        };

        var orderValidator = new OrderValidator();
        var paymentProcessor = new PaymentProcessor();
        var notificationService = new NotificationService();

        var orderProcessor = new OrderProcessor(orderValidator, paymentProcessor, notificationService);
        orderProcessor.ProcessOrder(order);
    }
}