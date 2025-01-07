
using Observer;

internal class Stock : IStock
{
    private readonly List<IInvestor> observers = new List<IInvestor>();
    private string stockName;
    private double price;

    public Stock(string stockName, double price)
    {
        this.stockName = stockName;
        this.price = price;
    }

    public string StockName => stockName;
    public double Price
    {
        get => price;
        set
        {
            if (price != value)
            {
                price = value;
                NotifyObservers();
            }
        }
    }
    public void RegisterObserver(IInvestor observer) => this.observers.Add(observer);
    public void RemoveObserver(IInvestor observer) => this.observers.Remove(observer);

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(this.stockName, this.Price);
        }
    }
}