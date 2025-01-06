namespace _05.DependencyInversionPrinciple.OrderService
{
    public interface IRefundablePaymentMethod : IPaymentMethod
    {
        void Refund(double amount);
    }
}
