namespace _02.OpenClosedPriciple.Discount
{
    public class SeniorUser : User, IDiscount
    {
        public SeniorUser(string userName, string password) 
            : base(userName, password)
        {
        }

        public override double GetDiscount() => 0.2;
    }
}
