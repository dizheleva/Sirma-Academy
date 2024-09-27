internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string row = "";

        for (int r = 1; r <= n; r++)
        {
            int rowLength = row.Length - 1 + r;
            int hashStart = rowLength - r;

            row = "";

            for (int c = 0; c < rowLength; c++)
            {
                row += c < hashStart ? ' ' : '#';
            }

            Console.WriteLine(row);
        }
    }
}