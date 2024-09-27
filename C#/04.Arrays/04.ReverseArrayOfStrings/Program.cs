internal class Program
{
    private static void Main(string[] args)
    {
        string[] arr = Console.ReadLine().Split(",");

        for (int i = 0; i < arr.Length / 2; i++)
        {
            string currentElement = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = currentElement;
        }

        Console.WriteLine(String.Join(" ", arr));
    }
}