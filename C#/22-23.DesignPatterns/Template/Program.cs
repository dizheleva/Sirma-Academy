internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Preparing tea...");
        Drink tea = new Tea();
        tea.Prepare();

        Console.WriteLine("\nPreparing coffee...");
        Drink coffee = new Coffee();
        coffee.Prepare();
    }
}