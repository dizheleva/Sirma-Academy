namespace _05.DependencyInversionPrinciple.OrderService
{
    public class OrderService
    {
        private readonly OrderValidator _validator;
        private readonly PaymentProcessor _paymentProcessor;
        private readonly DatabaseController _databaseController;
        private readonly OrderEmailSender _emailSender;

        public OrderService(
            OrderValidator orderValidator,
            PaymentProcessor paymentProcessor,
            DatabaseController dbController,
            OrderEmailSender emailSender)
        {
            _validator = orderValidator;
            _paymentProcessor = paymentProcessor;
            _databaseController = dbController;
            _emailSender = emailSender;
        }
        public void PlaceOrder(Order order)
        {
            // Validate
            _validator.ValidateOrder(order);
            // Process
            _paymentProcessor.ProcessPayment(order);
            // Save
            _databaseController.SaveOrder(order);
            // Notify
            _emailSender.SendEmail(order.CustomerEmail);
        }
    }
}
