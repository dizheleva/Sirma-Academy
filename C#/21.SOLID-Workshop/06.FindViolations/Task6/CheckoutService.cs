namespace _06.FindViolations.Task6
{
    public class CheckoutService
    {
        private readonly PaymentProcessor _paymentProcessor;
        private readonly PriceCalculator _priceCalculator;
        private readonly IDiscount _discount;

        public CheckoutService(PaymentProcessor paymentProcessor, PriceCalculator priceCalculator, IDiscount? discount)
        {
            _paymentProcessor = paymentProcessor;
            _priceCalculator = priceCalculator;
            _discount = discount;
        }

        public void Checkout(List<Product> products, IPaymentMethod paymentMethod)
        {
            if (_discount != null)
            {
                _priceCalculator.ApplyDiscount(products, _discount);
            }
            double totalPrice = _priceCalculator.CalculateTotalPrice(products);
            _paymentProcessor.ProcessPayment(paymentMethod, totalPrice);
        }
    }
}
