namespace _01.SingleResponsibilityPrinciple
{
    public class Order
    {
        public List<string> Items { get; set; } = [];
        public double TotalAmount { get; set; }
        public string CustomerEmail { get; set; }

        //public Order(List<string> items, double amount, string email)
        //{
        //    Items = items;
        //    TotalAmount = amount;
        //    CustomerEmail = email;
        //}
    }
}