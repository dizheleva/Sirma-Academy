internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

        int[] reversedArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            reversedArr[i] = arr[n - i - 1];
        }

        Console.WriteLine(String.Join(" ", reversedArr));
    }
}