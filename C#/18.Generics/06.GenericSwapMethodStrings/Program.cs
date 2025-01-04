using _06.GenericSwapMethodStrings;

internal class Program
{
    private static void Main(string[] args)
    {
        var count = int.Parse(Console.ReadLine());
        var items = new List<string>();

        for (var i = 0; i < count; i++)
        {
            items.Add(Console.ReadLine());
        }

        var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
        var boxes = Swap(items, indexes[0], indexes[1]);

        foreach (var box in boxes)
        {
            Console.WriteLine(box.ToString());
        }
    }

    public static List<Box<string>> Swap(List<string> items, int firstIndex, int secondIndex)
    {
        var boxList = new List<Box<string>>();

        var first = items[firstIndex];
        var second = items[secondIndex];

        foreach (var item in items)
        {
            if (item.Equals(first))
            {
                boxList.Add(new Box<string>(second));
            }
            else if (item.Equals(second))
            {
                boxList.Add(new Box<string>(first));
            }
            else
            {
                boxList.Add(new Box<string>(item));
            }
        }

        return boxList;
    }
}
