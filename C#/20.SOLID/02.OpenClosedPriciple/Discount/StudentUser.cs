namespace _02.OpenClosedPriciple.Discount
{
    public class StudentUser : User, IDiscount
    {
        public StudentUser(string userName, string password) 
            : base(userName, password)
        {
        }

        public override double GetDiscount() => 0.1;
    }
}
