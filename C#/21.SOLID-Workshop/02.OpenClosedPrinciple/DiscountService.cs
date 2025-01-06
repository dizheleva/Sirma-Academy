namespace _02.OpenClosedPrinciple
{
    public class DiscountService
    {
        private readonly DiscountRepository _discountRepository = new();
        public double CalculateDiscount(string discountType, double amount)
        {
            IDiscount discount = this._discountRepository.GetDiscountType(discountType);
            amount -= amount * discount.GetDiscount();

            return amount;
        }
    }
}
