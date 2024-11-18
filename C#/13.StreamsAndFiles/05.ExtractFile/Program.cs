internal class Program
{
    private static void Main(string[] args)
    {
        var filePath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\05.ExtractFile\\input.txt";

        FileInfo file = new FileInfo(filePath);

        if (file.Exists)
        {
            Console.WriteLine($"File name: {file.Name}");
            Console.WriteLine($"File extension: {file.Extension.Substring(1)}");
            Console.WriteLine($"File size: {file.Length} bytes");
        }
    }
}