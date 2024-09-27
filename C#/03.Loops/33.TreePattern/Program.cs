internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        char symbol = '*';
        string row;
        for (int r = 1; r <= n; r++)
        {
            row = "";

            for (int c = 1; c <= r * 2 - 1; c++)
            {
                while (row.Length < n - r)
                {
                    row += ' ';
                }

                row += symbol;
            }

            Console.WriteLine(row);
        }

        row = "";
        for (int s = 0; s < n - 1; s++)
        {
            row += ' ';
        }
        row += symbol;

        Console.WriteLine(row);
    }
}