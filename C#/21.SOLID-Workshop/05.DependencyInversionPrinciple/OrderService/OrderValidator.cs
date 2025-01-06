namespace _05.DependencyInversionPrinciple.OrderService
{
    public class OrderValidator
    {
        public void ValidateOrder(Order order)
        {
            if (order.Items.Count == 0)
            {
                throw new Exception("Order has no items.");
            }
        }
    }
}
