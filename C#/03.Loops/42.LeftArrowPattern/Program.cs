internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string row;

        for (int r = 1; r < n; r++)
        {
            row = "";

            while (row.Length < n - 1 - r)
            {
                row += ' ';
            }

            for (int c = 1; c <= r; c++)
            {
                row += '*';
            }

            Console.WriteLine(row);
        }

        for (int r = 1; r < n - 1; r++)
        {
            row = "";

            while (row.Length < r)
            {
                row += ' ';
            }

            for (int c = 1; c <= n - 1 - r; c++)
            {
                row += '*';
            }

            Console.WriteLine(row);
        }
    }
}