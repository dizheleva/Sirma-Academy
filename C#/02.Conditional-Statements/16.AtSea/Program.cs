using System;

internal class Program
{
    private static void Main(string[] args)
    {
        decimal singleRoom = 25.00m;
        decimal apartment = 50.00m;
        decimal presidential = 100.00m;

        int days = int.Parse(Console.ReadLine());
        string room = Console.ReadLine();
        string assesssment = Console.ReadLine();

        decimal totalPrice = 0;
        switch (room)
        {
            case "single room":
                totalPrice = singleRoom * (days - 1);
                break;
            case "apartment":
                totalPrice = apartment * (days - 1);
                switch (days)
                {
                    case < 10:
                        totalPrice = 0.7m * totalPrice;
                        break;
                    case <= 15:
                        totalPrice = 0.65m * totalPrice;
                        break;
                    case > 15:
                        totalPrice = 0.5m * totalPrice;
                        break;
                }
                break;
            case "presidential":
                totalPrice = presidential * (days - 1);
                switch (days)
                {
                    case < 10:
                        totalPrice = 0.9m * totalPrice;
                        break;
                    case <= 15:
                        totalPrice = 0.85m * totalPrice;
                        break;
                    case > 15:
                        totalPrice = 0.8m * totalPrice;
                        break;
                }
                break;
        }

        switch (assesssment)
        {
            case "positive":
                totalPrice = 1.25m * totalPrice;
                break;
            case "negative":
                totalPrice = 0.9m * totalPrice;
                break;
        }

        Console.WriteLine(totalPrice.ToString("F2"));
    }
}