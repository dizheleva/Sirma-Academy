internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<string> periodicTable = new HashSet<string>();
        int entries = int.Parse(Console.ReadLine());

        for (int i = 0; i < entries; i++)
        {
            periodicTable = periodicTable.Concat(Console.ReadLine().Split()).ToHashSet();
        }

        Console.WriteLine($"{String.Join(" ", periodicTable.Order())}");
    }
}