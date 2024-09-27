internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int currentNum = 0;

        for (int r = 1; currentNum < n; r++)
        {
            string output = "";

            int numbers = n;
            int rowCount = 0;
            while (numbers > 0)
            {
                rowCount++;
                numbers -= rowCount;
            }

            for (int s = 0; s < rowCount - r; s++)
            {
                output += ' ';
            }

            for (int c = 0; c < r && currentNum < n; c++)
            {
                currentNum++;
                output += $" {currentNum}";
            }

            Console.WriteLine(output);
        }
    }
}