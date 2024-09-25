internal class Program
{
    private static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());
        string cardStatus = Console.ReadLine();

        int discount = 0;
        switch (age)
        {
            case < 18:
                discount = 10;
                break;
            case <= 64:
                switch (cardStatus)
                {
                    case "Yes":
                        discount = 20;
                        break;
                    case "No":
                        discount = 10;
                        break;
                }
                break;
            case >= 65:
                discount = 30;
                break;
        }

        Console.WriteLine($"{discount}% discount");
    }
}