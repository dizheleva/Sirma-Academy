internal class Program
{
    private static void Main(string[] args)
    {
        string[] data = Console.ReadLine().Split("', [");
        string text = data[0].Substring(1);

        string[] words = data[1].Substring(0, data[1].Length - 1).Split(", ").Select(w => w.Substring(1, w.Length - 2)).ToArray();

        Array.Sort(words, (a, b) => b.Length - a.Length);

        var result = text;

        foreach (var word in words) {
            var hole = new string('_', word.Length);
            result = result.Replace(hole, word);
        }

        Console.WriteLine(result);
    }
}