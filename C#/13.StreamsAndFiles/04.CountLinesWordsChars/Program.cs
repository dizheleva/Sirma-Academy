internal class Program
{
    private static void Main(string[] args)
    {
        var filePath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\04.CountLinesWordsChars\\input.txt";

        using var reader = new StreamReader(filePath);
        var line = reader.ReadLine();
        var linesCount = 0;
        var wordsCount = 0;
        var charsCount = 0;

        while (line != null)
        {
            linesCount++;
            wordsCount += line.Split(" ").Length;
            charsCount += line.Length;

            line = reader.ReadLine();
        }

        Console.WriteLine($"Lines: {linesCount}");
        Console.WriteLine($"Words: {wordsCount}");
        Console.WriteLine($"Characters: {charsCount}");
    }
}