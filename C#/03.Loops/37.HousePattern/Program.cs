internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string row;        

        int roofRows = (int)Math.Ceiling(n / 2.0);
        for (int r = 1; r <= roofRows; r++)
        {
            row = "";

            int roofWidth = n - 2 * (roofRows - r);            
            for (int c = 1; c <= roofWidth; c++)
            {
                while (row.Length < roofRows - r)
                {
                    row += ' ';
                }

                row += '*';
            }

            Console.WriteLine(row);
        }

        for (int i = 0; i < 2; i++)
        {
            row = "";

            for (int s = 0; s < n; s++)
            {
                row += s == 0 || s == n - 1 ? '*' : ' ';
            }

            Console.WriteLine(row);
        }
    }
}