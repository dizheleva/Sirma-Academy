internal class Program
{
    private static void Main(string[] args)
    {
        int minutes = int.Parse(Console.ReadLine());
        int hours = minutes / 60;
        int remainingMinutes = minutes % 60;

        string time = $"{hours:D2}:{remainingMinutes:D2}";

        Console.WriteLine(time);
    }
}