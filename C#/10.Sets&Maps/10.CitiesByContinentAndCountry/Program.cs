internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, List<string>>> map = [];

        int entriesCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < entriesCount; i++)
        {
            string[] dataEntries = Console.ReadLine().Split(" ");
            string continent = dataEntries[0];
            string country = dataEntries[1];
            string city = dataEntries[2];

            if (!map.ContainsKey(continent))
            {
                map.Add(continent, []);
            }

            if (!map[continent].ContainsKey(country))
            {
                map[continent].Add(country, []);
            }

            map[continent][country].Add(city);
        }

        foreach (var continent in map)
        {
            Console.WriteLine($"{continent.Key}:");
            foreach (var country in continent.Value)
            {
                Console.WriteLine($"  {country.Key} -> {String.Join(", ", country.Value)}");
            }
        }
    }
}