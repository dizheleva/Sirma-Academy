
internal class Program
{
    private static void Main(string[] args)
    {
        int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[,] matrix = ReadMatrix(sizes[0], sizes[1]);

        matrix = FlipBorder(matrix);
        PrintMatrix(matrix);
    }

    private static int[,] FlipBorder(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] newMatrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (row != rows - 1 && col == 0)
                {
                    newMatrix[row, col] = matrix[row + 1, col];
                }
                else if (row == 0 && col != 0)
                {
                    newMatrix[row, col] = matrix[row, col - 1];
                }
                else if (row != 0 && col == cols - 1)
                {
                    newMatrix[row, col] = matrix[row - 1, col];
                }
                else if (row == rows - 1 && col != cols - 1)
                {
                    newMatrix[row, col] = matrix[row, col + 1];
                }
                else
                {
                    newMatrix[row, col] = matrix[row, col];
                }
            }
        }

        return newMatrix;
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
            int[] rowValues = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = rowValues[col];
            }
        }

        return matrix;
    }
}