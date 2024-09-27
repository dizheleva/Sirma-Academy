internal class Program
{
    private static void Main(string[] args)
    {
        double amount = double.Parse(Console.ReadLine());

        int coinCounter = 0;
        int changeInCents = (int)Math.Floor(amount * 100);

        while (changeInCents > 0)
        {
            if (changeInCents >= 200)
            {
                changeInCents -= 200;
            }
            else if (changeInCents >= 100)
            {
                changeInCents -= 100;
            }
            else if (changeInCents >= 50)
            {
                changeInCents -= 50;
            }
            else if (changeInCents >= 20)
            {
                changeInCents -= 20;
            }
            else if (changeInCents >= 10)
            {
                changeInCents -= 10;
            }
            else if (changeInCents >= 5)
            {
                changeInCents -= 5;
            }
            else if (changeInCents >= 2)
            {
                changeInCents -= 2;
            }
            else if (changeInCents == 1)
            {
                changeInCents--;
            }
            coinCounter++;
        }

        Console.WriteLine(coinCounter);
    }
}