internal class Program
{
    private static void Main(string[] args)
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        decimal amount = 0;
        string destination = "";
        string holiday = "";

        switch (budget)
        {
            case <= 100:
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        amount = 0.3m * budget;
                        holiday = "Camp";
                        break;
                    case "winter":
                        amount = 0.7m * budget;
                        holiday = "Hotel";
                        break;
                }
                break;
            case <= 1000:
                destination = "Europe";
                switch (season)
                {
                    case "summer":
                        amount = 0.4m * budget;
                        holiday = "Camp";
                        break;
                    case "winter":
                        amount = 0.8m * budget;
                        holiday = "Hotel";
                        break;
                }
                break;
            case > 1000:
                destination = "Asia";
                amount = 0.9m * budget;
                holiday = "Hotel";
                break;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{holiday} - {amount:F2}");
    }
}