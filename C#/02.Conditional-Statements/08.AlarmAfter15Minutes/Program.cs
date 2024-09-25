internal class Program
{
    private static void Main(string[] args)
    {
        int inputHour = int.Parse(Console.ReadLine());
        int inputMinutes = int.Parse(Console.ReadLine());

        int resultMinutes = (inputMinutes + 15) % 60;
        int resultHour = (inputHour + (inputMinutes + 15) / 60) % 24;

        Console.WriteLine($"{resultHour}:{resultMinutes:D2}");
    }
}