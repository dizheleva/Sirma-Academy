namespace _02.OpenClosedPriciple.Discount
{
    public class RegularUser : User, IDiscount
    {
        public RegularUser(string userName, string password) 
            : base(userName, password)
        {
        }

        public override double GetDiscount() => 0;
    }
}
