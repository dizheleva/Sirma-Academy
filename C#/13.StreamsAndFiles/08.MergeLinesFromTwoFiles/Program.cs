internal class Program
{
    private static void Main(string[] args)
    {
        var filePath1 = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\08.MergeLinesFromTwoFiles\\input1.txt";
        var filePath2 = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\08.MergeLinesFromTwoFiles\\input2.txt";
        using var reader1 = new StreamReader(filePath1);
        using var reader2 = new StreamReader(filePath2);
        string line1 = reader1.ReadLine();
        string line2 = reader2.ReadLine();

        var outputPath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\08.MergeLinesFromTwoFiles\\output.txt";
        using var writer = new StreamWriter(outputPath);

        while (true)
        { 
            if (line1 != null)
            {
                writer.Write(line1);
            }

            if (line2 != null)
            {
                if (line1 != null)
                {
                    writer.WriteLine();
                }

                writer.Write(line2);
            }

            line1 = reader1.ReadLine();
            line2 = reader2.ReadLine();

            if (line1 == null && line2 == null)
            {
                break;
            }

            writer.WriteLine();
        }
    }
}