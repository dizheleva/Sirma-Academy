internal class Program
{
    private static void Main(string[] args)
    {
        SortedDictionary<string, List<double>> map = [];
        int entryCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < entryCount; i++)
        {
            string[] data = Console.ReadLine().Split(" ");
            string student = data[0];
            double grade = double.Parse(data[1]);

            if (!map.ContainsKey(student))
            {
                map.Add(student, []);
            }

            map[student].Add(grade);
        }

        foreach (var item in map)
        {
            Console.WriteLine($"{item.Key} -> {String.Join(' ', item.Value.Select(x => x.ToString("F2")))} (avg: {item.Value.Average():F2})");
        }
    }
}