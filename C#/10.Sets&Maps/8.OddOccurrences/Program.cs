internal class Program
{
    private static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(' ').Select(w => w.ToLower()).ToArray();

        Dictionary<string, int> map = words.Distinct().ToDictionary(x => x, x => words.Count(y => y == x));

        string[] oddMap = map.Where(x => x.Value % 2 != 0).Select(w => w.Key).ToArray();

        Console.WriteLine($"{String.Join(", ", oddMap)}");
    }
}