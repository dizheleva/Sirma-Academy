internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int r = 1; r <= n; r++)
        {
            string row = "";

            for (int c = 1; c <= n * 5; c++)
            {
                char symbol;

                if (((r == 1 || r == n) && (c <= n * 2 || c > n * 3))
                    || c == 1 || c == n * 2 || c == n * 3 + 1 || c == n * 5)
                {
                    symbol = '*';
                }
                else if (c > n * 2 && c <= n * 3)
                {
                    symbol = r == Math.Ceiling(n / 2.0) ? '|' : ' ';
                }
                else
                {
                    symbol = '/';
                }

                row += symbol;
            }

            Console.WriteLine(row);
        }
    }
}