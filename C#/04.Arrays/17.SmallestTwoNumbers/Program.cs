internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

        int[] outputArr = new int[2];

        for (int i = 0; i < 2; i++)
        {
            int smallest = arr.Min();
            outputArr[i] = smallest;
            int smallestIndex = Array.IndexOf(arr, smallest);
            arr[smallestIndex] = Int32.MaxValue;
        }

        Console.WriteLine(String.Join(' ', outputArr));
    }
}