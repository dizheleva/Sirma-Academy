internal class Program
{
    private static void Main(string[] args)
    {
        var inputText = Console.ReadLine().Split();

        var resultText = string.Empty;

        foreach (var word in inputText)
        {
            foreach (var ch in word)
            {
                resultText += word;
            }
        }

        Console.WriteLine(resultText);
    }
}