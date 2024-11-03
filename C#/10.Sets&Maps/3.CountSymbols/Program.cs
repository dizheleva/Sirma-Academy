internal class Program
{
    private static void Main(string[] args)
    {
        SortedDictionary<char, int> map = [];
        string text = Console.ReadLine();

        foreach (var ch in text)
        {            
            if (!map.ContainsKey(ch))
            {
                map.Add(ch, 0);
            }

            map[ch]++;
        }

        foreach (var item in map)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}