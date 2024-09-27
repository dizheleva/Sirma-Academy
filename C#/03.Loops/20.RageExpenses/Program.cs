internal class Program
{
    private static void Main(string[] args)
    {
        int lostGames = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        double headsetsCost = 0;
        double mousesCost = 0;
        double keyboardsCost = 0;
        double displaysCost = 0;

        int keyboardsCounter = 0;
        for (int game = 1; game <= lostGames; game++)
        {

            if (game % 2 == 0)
            {
                headsetsCost += headsetPrice;
            }

            if (game % 3 == 0)
            {
                mousesCost += mousePrice;
            }

            if (game % 2 == 0 && game % 3 == 0)
            {
                keyboardsCost += keyboardPrice;
                keyboardsCounter++;

                if (keyboardsCounter % 2 == 0)
                {
                    displaysCost += displayPrice;
                    keyboardsCounter = 0;
                }
            }
        }

        double totalCost = headsetsCost + mousesCost + keyboardsCost + displaysCost;
        Console.WriteLine($"Rage expenses: {totalCost:F2} lv.");
    }
}