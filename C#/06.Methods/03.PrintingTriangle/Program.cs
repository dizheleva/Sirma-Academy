
internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        PrintTriangleOfNumbers(number);
    }

    private static void PrintTriangleOfNumbers(int number)
    {
        int rowsCount = number * 2 - 1;

        for (int row = 1; row <= rowsCount; row++)
        {
            int lastNumber = row <= number ? row : rowsCount - row + 1;

            for (int num = 1; num <= lastNumber; num++)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}