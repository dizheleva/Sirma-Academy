internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> map = [];

        string command;
        while ((command = Console.ReadLine()) != "report")
        {
            UpdateHands(map, command);
        }

        foreach (var country in map.OrderByDescending(x => x.Value.Sum(kvp => kvp.Value)))
        {
            Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(kvp => kvp.Value)})");
            foreach (var city in country.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }
    }

    private static void UpdateHands(Dictionary<string, Dictionary<string, int>> map, string data)
    {
        var dataArgs = data.Split('|');
        var city = dataArgs[0];
        var country = dataArgs[1];
        var population = int.Parse(dataArgs[2]);

        if (!map.ContainsKey(country))
        {
            map.Add(country, []);
        }

        if (!map[country].ContainsKey(city))
        {
            map[country].Add(city, 0);
        }

        map[country][city] = population;
    }
}