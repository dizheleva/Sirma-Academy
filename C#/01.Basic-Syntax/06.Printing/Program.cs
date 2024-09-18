using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        string text = Console.ReadLine();
        char symbol = char.Parse(Console.ReadLine());
        int integer = int.Parse(Console.ReadLine());
        double realNumber = double.Parse(Console.ReadLine());

        Console.WriteLine($"text = {text}");
        Console.WriteLine($"symbol = {symbol}");
        Console.WriteLine($"integer = {integer}");
        Console.WriteLine($"real number = {realNumber}");

        Console.Write($"text = {text}, ");
        Console.Write($"symbol = {symbol}, ");
        Console.Write($"integer = {integer}, ");
        Console.WriteLine($"real number = {realNumber}");
    }
}