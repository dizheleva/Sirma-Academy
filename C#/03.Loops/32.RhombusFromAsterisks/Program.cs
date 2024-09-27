internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int rows = n * 2 - 1;
        string symbol = "* ";

        for (int r = 0; r < rows; r++)
        {
            string row = "";

            int colEnd = r < n ? r + 1 : rows - r;

            for (int c = 0; c < colEnd; c++)
            {
                int spacesCount = Math.Abs(n - (r + 1));                

                while (row.Length < spacesCount)
                {
                    row += ' ';
                }

                row += symbol;
            }            

            Console.WriteLine(row);
        }
    }
}