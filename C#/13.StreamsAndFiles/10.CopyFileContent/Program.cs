internal class Program
{
    private static void Main(string[] args)
    {
        var inputPath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\10.CopyFileContent\\input.txt";
        var outputPath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\10.CopyFileContent\\output.txt";

        var content = File.ReadAllText(inputPath);
        File.WriteAllText(outputPath, content);
    }
}