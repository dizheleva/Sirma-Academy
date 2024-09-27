internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        for (int r = 0; r < n; r++)
        {
            string row = "";

            for (int c = 0; c < m; c++)
            {
                char symbol;
                bool isBorderRow = r == 0 || r == n - 1;
                bool isBorderCol = c == 0 || c == m - 1;

                if (isBorderRow || isBorderCol)
                {
                    symbol = '*';
                }
                else
                {
                    symbol = ' ';
                }

                row += symbol;
            }

            Console.WriteLine(row);
        }
    }
}