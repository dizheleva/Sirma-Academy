internal class Program
{
    private static void Main(string[] args)
    {
        Stock googleStock = new Stock("Google", 1340.25);

        Investor alice = new Investor("Alice");
        Investor bob = new Investor("Bob");

        googleStock.RegisterObserver(alice);
        googleStock.RegisterObserver(bob);

        Console.WriteLine("Google stock price changed to 1350.50");
        googleStock.Price = 1350.50;

        Console.WriteLine("Bob is no longer watching Google stock");
        googleStock.RemoveObserver(bob);

        Console.WriteLine("Google stock price changed to 1360.00");
        googleStock.Price = 1360.00;
    }
}