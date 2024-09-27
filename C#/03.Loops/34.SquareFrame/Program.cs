internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int r = 1; r <= n; r++)
        {
            string row = "";

            for (int c = 1; c <= n; c++)
            {
                char symbol;
                
                if ((r == 1 || r == n) && (c == 1 || c == n))
                {
                    symbol = '+';
                }
                else if (c == 1 || c == n)
                {
                    symbol = '|';
                }
                else
                {
                    symbol = '-';
                }

                row += symbol;
            }

            Console.WriteLine(row);
        }
    }
}