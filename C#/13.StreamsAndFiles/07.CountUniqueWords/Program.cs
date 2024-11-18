internal class Program
{
    private static void Main(string[] args)
    {
        var filePath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\07.CountUniqueWords\\input.txt";

        using var reader = new StreamReader(filePath);
        var line = reader.ReadLine();
        var wordCounts = new Dictionary<string, int>();

        while (line != null)
        {
            var words = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts.Add(word, 1);
                }
            }

            line = reader.ReadLine();
        }

        Console.WriteLine($"Unique words: {wordCounts.Count(w => w.Value == 1)}");
    }
}