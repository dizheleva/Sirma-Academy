internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int rows = n * 2 - 1;
        string symbol = "* ";

        for (int r = 1; r <= rows; r++)
        {
            string row = "";

            int colEnd = r <= n ? r : rows - r + 1;

            for (int c = 1; c <= colEnd; c++)
            {
                row += symbol;
            }

            Console.WriteLine(row.Trim());
        }
    }
}