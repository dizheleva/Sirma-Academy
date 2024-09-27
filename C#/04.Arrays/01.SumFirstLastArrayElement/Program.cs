internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

        int firstNumber = arr[0];
        int lastNumber = arr[arr.Length - 1];

        int result = firstNumber + lastNumber;
        Console.WriteLine(result);
    }
}