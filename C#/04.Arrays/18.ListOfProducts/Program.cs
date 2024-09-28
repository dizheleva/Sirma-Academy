internal class Program
{
    private static void Main(string[] args)
    {
        string[] arr = Console.ReadLine().Split(", ");

        arr = arr.OrderBy(e => e).ToArray();

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"{i + 1}.{arr[i]}");
        }
    }
}