internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int r = 1; r <= n; r++)
        {
            string row = "";

            int rowCounter = r;
            for (int c = n - r + 1; c < n + r; c++)
            {
                while (row.Length < n - r + 1)
                {
                    row += ' ';
                }

                row += rowCounter;
                rowCounter += c >= n ? -1 : 1;
            }

            Console.WriteLine(row);
        }
    }
}