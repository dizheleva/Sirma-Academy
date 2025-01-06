namespace _01.SingleResponsibilityPrinciple
{
    public class OrderValidator
    {
        public void Validate(Order order)
        {
            if (order.Items.Count == 0)
            {
                throw new Exception("Order has no items.");
            }
        }
    }
}
