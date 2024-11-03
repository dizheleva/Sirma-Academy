
internal class Program
{
    private static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        int[,] checkerboard = CreatePattern(size);

        PrintMatrix(checkerboard);
    }

    private static int[,] CreatePattern(int size)
    {
        int[,] matrix = new int[size, size];

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                bool isRowEven = row % 2 == 0;
                bool isColOdd = col % 2 != 0;
                bool isBlackCell = isRowEven && isColOdd || !isRowEven && !isColOdd;

                matrix[row, col] = isBlackCell ? 1 : 0;
            }
        }

        return matrix;
    }

        private static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int row = 0; row < rows; row++)
        {
            string rowValues = string.Empty;
            for (int col = 0; col < cols; col++)
            {
                rowValues += matrix[row, col] + " ";
            }

            Console.WriteLine(rowValues.Trim());
        }
    }
}