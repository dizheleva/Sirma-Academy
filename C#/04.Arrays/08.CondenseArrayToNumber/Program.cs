internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

        while (arr.Length > 1)
        {
            int[] condensedArray = new int[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                condensedArray[i] = arr[i] + arr[i + 1];
            }

            arr = condensedArray;
        }

        Console.WriteLine(arr[0]);
    }
}