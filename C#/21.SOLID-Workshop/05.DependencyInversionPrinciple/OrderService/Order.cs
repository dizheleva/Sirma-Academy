namespace _05.DependencyInversionPrinciple.OrderService
{
    public class Order
    {
        public List<string> Items { get; set; } = [];
        public double TotalAmount { get; set; }
        public string CustomerEmail { get; set; }
        public IPaymentMethod PaymentMethod { get; set; }
    }
}
