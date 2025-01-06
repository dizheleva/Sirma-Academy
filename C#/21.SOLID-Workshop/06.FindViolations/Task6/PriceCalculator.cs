namespace _06.FindViolations.Task6
{
    public class PriceCalculator
    {
        public double CalculateTotalPrice(List<Product> products)
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Price * (1 - product.Discount);
            }
            return total;
        }
        public void ApplyDiscount(List<Product> products, IDiscount discount)
        {
            foreach (var product in products)
            {
                product.Discount = discount.GetDiscount();
            }
        }
    }
}
