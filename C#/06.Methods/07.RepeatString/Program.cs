
internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int repeatCount = int.Parse(Console.ReadLine());
        string output = RepeatString(input, repeatCount);
        Console.WriteLine(output);
    }

    private static string RepeatString(string input, int repeatCount)
    {
        string result = string.Empty;
        for (int i = 0; i < repeatCount; i++)
        {
            result += input;
        }

        return result;
    }
}