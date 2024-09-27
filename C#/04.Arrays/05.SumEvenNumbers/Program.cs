internal class Program
{
    private static void Main(string[] args)
    {
        string[] arr = Console.ReadLine().Split(",");

        int sum = 0;

        foreach (string element in arr)
        {
            int number = int.Parse(element);

            if (number % 2 == 0)
            {
                sum += number;
            }
        }

        Console.WriteLine(sum);
    }
}