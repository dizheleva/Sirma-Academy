internal class Program
{
    private static void Main(string[] args)
    {
        double speed = double.Parse(Console.ReadLine());

        string result = "";
        switch (speed)
        {
            case <= 10:
                result = "slow";
                break;
            case <= 60:
                result = "average";
                break;
            case <= 120:
                result = "fast";
                break;
            case <= 160:
                result = "super-fast";
                break;
            case > 160:
                result = "turbo-fast";
                break;
        }

        Console.WriteLine(result);
    }
}