namespace _05.DependencyInversionPrinciple.OrderService
{
    public interface IPaymentMethod
    {
        void Pay(double amount);
    }
}
