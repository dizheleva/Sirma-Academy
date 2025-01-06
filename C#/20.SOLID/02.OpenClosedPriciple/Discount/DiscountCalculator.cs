namespace _02.OpenClosedPriciple.Discount
{
    public class DiscountCalculator
    {
        public double CalculateDiscount(User user, double price)
        {
            return price -= user.GetDiscount() * price;
        }
    }
}
