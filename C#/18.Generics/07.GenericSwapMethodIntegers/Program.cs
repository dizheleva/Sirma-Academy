using _07.GenericSwapMethodIntegers;

internal class Program
{
    private static void Main(string[] args)
    {
        var count = int.Parse(Console.ReadLine());
        var items = new List<int>();

        for (var i = 0; i < count; i++)
        {
            items.Add(int.Parse(Console.ReadLine()));
        }

        var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var swapper = new Swapper<int>();
        var boxes = swapper.Swap(items, indexes[0], indexes[1]);

        foreach (var box in boxes)
        {
            Console.WriteLine(box.ToString());
        }
    }
}