internal class Program
{
    private static void Main(string[] args)
    {
        var filePath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\06.ReverseLines\\input.txt";

        using var reader = new StreamReader(filePath);
        string line = reader.ReadLine();

        var outputPath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\06.ReverseLines\\output.txt";
        using var writer = new StreamWriter(outputPath);

        while (true)
        {
            var reversedChars = line.ToCharArray();
            Array.Reverse(reversedChars);            
            writer.Write(reversedChars);

            line = reader.ReadLine();
            if (line == null)
            {
                break;
            }
            else
            {
                writer.WriteLine();
            }
        }
    }
}