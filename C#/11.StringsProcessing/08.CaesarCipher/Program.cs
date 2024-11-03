using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var text = Console.ReadLine();

        var encryptedText = new StringBuilder();

        foreach (var symbol in text)
        {
            var encryptedSymbol = (char)(symbol + 3);
            encryptedText.Append(encryptedSymbol);
        }

        Console.WriteLine(encryptedText);
    }
}