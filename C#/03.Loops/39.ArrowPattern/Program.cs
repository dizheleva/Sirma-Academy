internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string row;
        for (int r = 1; r < n; r++)
        {
            row = "";
                        
            for (int c = 1; c <= r; c++)
            {
                while (row.Length < n - 1 - r)
                {
                    row += ' ';
                }
                row += "* ";
            }

            Console.WriteLine(row);
        }

        for (int r = 1; r < n; r++)
        {
            row = "";
            int spaceLength;
            int starLength;
            if (n % 2 == 0)
            {
                spaceLength = (n - 2) / 2;
                starLength = n - 1;
            }
            else
            {
                spaceLength = (n - 1) / 2;
                starLength = n - 2;
            }

            for (int c = 0; c < starLength; c++)
            {

                while (row.Length < spaceLength)
                {
                    row += ' ';
                }
                row += '*';
            }

            Console.WriteLine(row);
        }
    }
}