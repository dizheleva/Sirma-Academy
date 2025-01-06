namespace _03.LiskovSubstitutionPrinciple
{
    public interface IRefundablePaymentMethod : IPaymentMethod
    {
        void Refund(double amount);
    }
}
