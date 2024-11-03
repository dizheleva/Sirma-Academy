internal class Program
{
    private static void Main(string[] args)
    {
        string columnName = Console.ReadLine();

        int columnNumber = 0;

        for (int i = 0; i < columnName.Length; i++)
        {
            int letterValue = columnName[columnName.Length - 1 - i] - 'A' + 1;
            columnNumber += letterValue + 25 * i * letterValue;
        }

        Console.WriteLine(columnNumber);
    }
}