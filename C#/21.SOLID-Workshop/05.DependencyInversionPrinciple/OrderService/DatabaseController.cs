namespace _05.DependencyInversionPrinciple.OrderService
{
    public class DatabaseController
    {
        public void SaveOrder(Order order)
        {
            Console.WriteLine("Saving order to database...");
        }
    }
}
