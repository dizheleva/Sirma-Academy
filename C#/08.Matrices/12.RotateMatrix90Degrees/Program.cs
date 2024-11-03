
internal class Program
{
    private static void Main(string[] args)
    {
        int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[,] matrix = ReadMatrix(sizes[0], sizes[1]);

        matrix = RotateMatrix(matrix);

        PrintMatrix(matrix);
    }

    private static int[,] RotateMatrix(int[,] matrix)
    {
        int cols = matrix.GetLength(0);
        int rows = matrix.GetLength(1);

        int[,] rotated = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = cols - 1; col >= 0; col--)
            {
                rotated[row, col] = matrix[cols - 1 - col, row];
            }
        }

        return rotated;
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

    private static int[,] ReadMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            int[] rowValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = rowValues[col];
            }
        }

        return matrix;
    }
}