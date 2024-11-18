internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" -> ");
        var word = input[0];
        var replacement = input[1];

        var filePath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\03.ReplaceWord\\input.txt";
        var text = File.ReadAllText(filePath);
        text = text.Replace(word, replacement);

        var outputPath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\03.ReplaceWord\\output.txt";
        File.WriteAllText(outputPath, text);        
    }
}