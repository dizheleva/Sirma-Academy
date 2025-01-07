namespace Observer
{
    public interface IStock
    {
        void RegisterObserver(IInvestor observer);
        void RemoveObserver(IInvestor observer);
        void NotifyObservers();
    }
}
