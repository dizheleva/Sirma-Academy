
internal class Program
{
    private static void Main(string[] args)
    {
        string product = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());
        PrintOrder(product, quantity);
    }

    private static void PrintOrder(string product, double quantity)
    {
        double price = 0;
        switch (product)
        {
            case "coffee":
                price = 1.50;
                break;
            case "water":
                price = 1.00;
                break;
            case "cake":
                price = 1.40;
                break;
            case "snacks":
                price = 2.00;
                break;
            default:
                Console.WriteLine("Invalid product!");
                break;
        }

        double result = price * quantity;
        Console.WriteLine(result.ToString("F2"));
    }
}