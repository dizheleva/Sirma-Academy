public interface IPayment
{
    void ProcessPayment(string account, decimal amount);
}