internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int num = 1; num <= 1000; num++)
        {
            if (num % 10 == n)
            {
                Console.WriteLine(num);
            }
        }
    }
}