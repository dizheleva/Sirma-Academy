using Observer;

public class Investor : IInvestor
{
    public string Name { get; set; }

    public Investor(string name)
    {
        this.Name = name;
    }

    public void Update(string stockName, double price)
    {
        Console.WriteLine($"Investor {this.Name} notified. {stockName} stock is now priced at {price:C}");
    }
}