internal class Program
{
    private static void Main(string[] args)
    {
        List<int> ints = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        int maxNumsCount = ints.Count < 3 ? ints.Count : 3;

        for (int i = 0; i < maxNumsCount; i++)
        {
            Console.Write($"{ints.Max()} ");
            ints.Remove(ints.Max());
        }
    }
}