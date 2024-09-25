internal class Program
{
    private static void Main(string[] args)
    {
        string product = Console.ReadLine();
        string city = Console.ReadLine();
        decimal quantity = decimal.Parse(Console.ReadLine());

        decimal price = 0;

        switch (product)
        {
            case "tea":
                switch (city)
                {
                    case "Sofia":
                        price = 0.5m;
                        break;
                    case "Plovdiv":
                        price = 0.4m;
                        break;
                    case "Varna":
                        price = 0.45m;
                        break;
                }
                break;
            case "water":
                switch (city)
                {
                    case "Sofia":
                        price = 0.8m;
                        break;
                    case "Plovdiv":
                        price = 0.7m;
                        break;
                    case "Varna":
                        price = 0.7m;
                        break;
                }
                break;
            case "juice":
                switch (city)
                {
                    case "Sofia":
                        price = 1.2m;
                        break;
                    case "Plovdiv":
                        price = 1.15m;
                        break;
                    case "Varna":
                        price = 1.1m;
                        break;
                }
                break;
            case "sweets":
                switch (city)
                {
                    case "Sofia":
                        price = 1.45m;
                        break;
                    case "Plovdiv":
                        price = 1.3m;
                        break;
                    case "Varna":
                        price = 1.35m;
                        break;
                }
                break;
            case "chips":
                switch (city)
                {
                    case "Sofia":
                        price = 1.60m;
                        break;
                    case "Plovdiv":
                        price = 1.5m;
                        break;
                    case "Varna":
                        price = 1.55m;
                        break;
                }
                break;
        }

        decimal result = quantity * price;
        Console.WriteLine(result.ToString("F2"));
    }
}