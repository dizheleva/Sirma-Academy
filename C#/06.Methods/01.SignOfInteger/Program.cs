internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        PrintSign(number);
    }

    public static void PrintSign(int number)
    {
        string output;

        switch (number)
        {
            case > 0:
                output = $"The number {number} is positive.";
                break;
            case < 0:
                output = $"The number {number} is negative.";
                break;
            default:
                output = $"The number {number} is zero.";
                break;
        }

        Console.WriteLine(output);
    }
}