internal class Program
{
    private static void Main(string[] args)
    {
        int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int lengthOne = lengths[0];
        int lengthTwo = lengths[1];

        HashSet<int> setOne = [];
        HashSet<int> setTwo = [];

        for (int i = 0; i < lengthOne; i++)
        {
            int number = int.Parse(Console.ReadLine());
            setOne.Add(number);
        }

        for (int i = 0; i < lengthTwo; i++)
        {
            int number = int.Parse(Console.ReadLine());
            setTwo.Add(number);
        }

        var result = setOne.Intersect(setTwo).ToHashSet();
        Console.WriteLine(String.Join(" ", result));
    }
}