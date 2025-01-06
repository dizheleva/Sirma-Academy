namespace _02.OpenClosedPrinciple
{
    public class DiscountRepository
    {
        private readonly Dictionary<string, IDiscount> _discounts;

        public DiscountRepository()
        {
            this._discounts = new Dictionary<string, IDiscount>()
            {
                {"Student", new StudentDiscount() },
                {"Senior", new SeniorDiscount() },
                {"Seasonal", new SeasonalDiscount() }
            };
        }

        public IDiscount GetDiscountType(string discountType)
        {
            return this._discounts.GetValueOrDefault(discountType);
        }
    }
}
