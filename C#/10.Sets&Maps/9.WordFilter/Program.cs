internal class Program
{
    private static void Main(string[] args)
    {
        var words = Console.ReadLine().Split(' ').Where(w => w.Length % 2 == 0).ToList();

        words.ForEach(word => Console.WriteLine(word));
    }
}