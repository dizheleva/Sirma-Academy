internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            int current = 2 * i + 1;
            Console.WriteLine(current);
            sum += current;
        }

        Console.WriteLine($"Sum: {sum}");
    }
}