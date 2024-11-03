
internal class Program
{
    private static void Main(string[] args)
    {
        SortedDictionary<string, List<string>> synonymDictionary = [];
        
        int wordsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < wordsCount; i++)
        {
            string word = Console.ReadLine();
            string synonym = Console.ReadLine();

            UpdateDictionary(synonymDictionary, word, synonym);
        }

        PrintDictionary(synonymDictionary);
    }

    private static void PrintDictionary(SortedDictionary<string, List<string>> synonymDictionary)
    {
        foreach (var item in synonymDictionary)
        {
            Console.WriteLine($"{item.Key} - {String.Join(", ", item.Value)}");
        }
    }

    private static void UpdateDictionary(SortedDictionary<string, List<string>> synonymDictionary, string word, string synonym)
    {
        if (!synonymDictionary.ContainsKey(word))
        {
            synonymDictionary.Add(word, []);
        }

        if (!synonymDictionary[word].Contains(synonym))
        {
            synonymDictionary[word].Add(synonym);
        }
    }
}