internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i <= n * 2; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }
}