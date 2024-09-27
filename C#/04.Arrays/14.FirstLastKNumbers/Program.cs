internal class Program
{
    private static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

        int[] firstNumbersArr = new int[k];
        int[] lastNumbersArr = new int[k];

        for (int i = 0; i < k; i++)
        {
            firstNumbersArr[i] = arr[i];
            lastNumbersArr[k - i - 1] = arr[arr.Length - 1 - i];
        }

        Console.WriteLine(String.Join(' ', firstNumbersArr));
        Console.WriteLine(String.Join(' ', lastNumbersArr));
    }
}