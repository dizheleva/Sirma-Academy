internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string symbol;
       
        for (int r = 0; r <= n; r++)
        {
            string row = "";

            for (int c = 0; c < r * 2 + 1; c++)
            {
                while (row.Length < n - r)
                {
                    row += ' ';
                }

                symbol = c == r ? " | " : "*";                
                row += symbol;
            }

            Console.WriteLine(row);
        }
    }
}