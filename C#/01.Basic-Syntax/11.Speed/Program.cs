internal class Program
{
    private static void Main(string[] args)
    {
        int meters = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        int totalSeconds = seconds + minutes * 60 + hours * 3600;

        double speed = meters / (totalSeconds * 1.00);
        Console.WriteLine($"{speed:F6}");
    }
}