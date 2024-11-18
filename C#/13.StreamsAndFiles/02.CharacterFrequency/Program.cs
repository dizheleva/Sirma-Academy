internal class Program
{
    private static void Main(string[] args)
    {
        var filePath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\02.CharacterFrequency\\input.txt";

        using var reader = new StreamReader(filePath);
        var charCounts = new Dictionary<char, int>();

        do
        {
            var ch = (char)reader.Read();

            if (charCounts.ContainsKey(ch))
            {
                charCounts[ch]++;
            }
            else
            {
                charCounts.Add(ch, 1);
            }
        }
        while (!reader.EndOfStream);

        foreach (var item in charCounts)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}