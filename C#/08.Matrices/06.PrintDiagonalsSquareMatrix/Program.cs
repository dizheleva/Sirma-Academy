
internal class Program
{
    private static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = ReadMatrix(size, size);

        int[] firstDiagonal = GetDiagonal(matrix, 0);
        int[] secondDiagonal = GetDiagonal(matrix, size - 1);

        Console.WriteLine(string.Join(" ", firstDiagonal));
        Console.WriteLine(string.Join(" ", secondDiagonal));
    }

    private static int[] GetDiagonal(int[,] matrix, int diagonalStart)
    {
        int[] diagonalValues = new int[matrix.GetLength(0)];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            diagonalValues[row] = matrix[Math.Abs(diagonalStart - row), row];
        }

        return diagonalValues;
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