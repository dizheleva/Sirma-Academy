namespace Observer
{
    public interface IInvestor
    {
        void Update(string stockName, double price);

    }
}