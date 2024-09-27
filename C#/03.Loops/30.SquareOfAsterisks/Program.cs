internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int r = 0; r < n; r++)
        {
            string row = "";

            for (int c = 0; c < n; c++)
            {
                row += "* ";
            }

            Console.WriteLine(row.Trim());
        }
    }
}