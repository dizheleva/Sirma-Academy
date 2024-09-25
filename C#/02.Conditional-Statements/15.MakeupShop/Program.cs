internal class Program
{
    private static void Main(string[] args)
    {
        decimal powder = 2.60m;
        decimal lipstick = 3;
        decimal spiral = 4.10m;
        decimal shadows = 8.20m;
        decimal concealer = 2;

        decimal renovationPrice = decimal.Parse(Console.ReadLine());
        int powdersCount = int.Parse(Console.ReadLine());
        int lipstickCount = int.Parse(Console.ReadLine());
        int spiralCount = int.Parse(Console.ReadLine());
        int shadowsCount = int.Parse(Console.ReadLine());
        int concealerCount = int.Parse(Console.ReadLine());

        int makeupCount = powdersCount + lipstickCount + spiralCount + shadowsCount + concealerCount;
        decimal totalOrder = powder * powdersCount 
            + lipstick * lipstickCount
            + spiral * spiralCount
            + shadows * shadowsCount
            + concealer * concealerCount;

        if (makeupCount >= 50)
        {
            totalOrder = 0.75m * totalOrder;
        }

        totalOrder = 0.9m * totalOrder;

        decimal moneyDifference = totalOrder - renovationPrice;

        if (moneyDifference >= 0)
        {
            Console.WriteLine($"Yes! {moneyDifference:F2} lv left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! {Math.Abs(moneyDifference):F2} lv needed.");
        }
    }
}