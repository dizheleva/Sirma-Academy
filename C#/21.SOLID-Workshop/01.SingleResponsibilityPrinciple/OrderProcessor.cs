namespace _01.SingleResponsibilityPrinciple
{
    public class OrderProcessor
    {
        private readonly OrderValidator _validator;
        private readonly PaymentProcessor _processor;
        private readonly NotificationService _notificator;

        public OrderProcessor(
            OrderValidator validator, 
            PaymentProcessor processor, 
            NotificationService notificator)
        {
            _validator = validator;
            _processor = processor;
            _notificator = notificator;
        }
        public void ProcessOrder(Order order)
        {            
            _validator.Validate(order);
            _processor.ProcessPayment(order);
            _notificator.NotifyCustomer(order);
        }
    }
}
