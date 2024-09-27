internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string row = "";

        int topBottomLength;
        int rowsCount;

        if (n % 2 == 0)
        {
            topBottomLength = n + 2;
            rowsCount = n - 1;
        }
        else
        {
            topBottomLength = n + 2;
            rowsCount = n;
        }

        // print first row
        for (int i = 0; i < topBottomLength; i++)
        {
            row += '#';
        }
        Console.WriteLine(row);

        //print body
        for (int r = 1; r <= rowsCount; r++)
        {
            row = "";

            for (int c = 1; c <= topBottomLength; c++)
            {
                bool isTop = r <= rowsCount / 2 + 1;
                int hashOne = r + 1; ;
                int hashTwo = topBottomLength - r; ;
                if (!isTop && n % 2 == 0)
                {
                    hashOne = r + 2;
                    hashTwo = topBottomLength - r - 1;
                }

                if (c == hashOne || c == hashTwo)
                {
                    row += '#';
                }
                else
                {
                    row += ' ';
                }
            }

            Console.WriteLine(row);
        }

        //print last row
        row = "";
        for (int i = 0; i < topBottomLength; i++)
        {
            row += '#';
        }
        Console.WriteLine(row);
    }
}