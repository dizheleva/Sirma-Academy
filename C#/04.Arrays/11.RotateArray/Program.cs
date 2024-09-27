internal class Program
{
    private static void Main(string[] args)
    {
        string[] arr = Console.ReadLine().Split(",");
        int n = int.Parse(Console.ReadLine());

        string[] outputArr = new string[arr.Length];
        int movedPositions = n % arr.Length;
        for (int i = 0; i < arr.Length; i++)
        {
            int currentIndex = i - movedPositions < 0 ? arr.Length + (i - movedPositions) : i - movedPositions;
            outputArr[i] = arr[currentIndex];
        }

        Console.WriteLine(String.Join(' ', outputArr));
    }
}