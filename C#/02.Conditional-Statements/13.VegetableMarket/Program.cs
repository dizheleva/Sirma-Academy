internal class Program
{
    private static void Main(string[] args)
    {
        string product = Console.ReadLine();
        string day = Console.ReadLine();
        decimal quantity = decimal.Parse(Console.ReadLine());

        decimal price = 0;

        switch (product)
        {
            case "tomato":
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 2.5m;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 2.8m;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                }
                break;
            case "onion":
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 1.2m;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 1.3m;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                }
                break;
            case "lettuce":
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 0.85m;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 0.85m;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                }
                break;
            case "cucumber":
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 1.45m;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 1.75m;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                }
                break;
            case "pepper":
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 5.5m;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 3.5m;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                }
                break;
            default:
                Console.WriteLine("error");
                return;
        }

        decimal result = quantity * price;
        Console.WriteLine(result.ToString("F2"));
    }
}