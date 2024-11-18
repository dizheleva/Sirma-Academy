internal class Program
{
    private static void Main(string[] args)
    {
        var filePath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\01.WordLengths\\input.txt";
        StreamReader reader = new StreamReader(filePath);
        using (reader)
        {
            string line = reader.ReadLine();
            List<int> lengths = [];

            while (line != null)
            {
                var lineWords = line.Split(" ");
                foreach (var word in lineWords)
                {
                    lengths.Add(word.Length);
                }

                line = reader.ReadLine();
            }

            Console.WriteLine(String.Join(", ", lengths));
        }
    }
}