
internal class Program
{
    private static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine().Split(" ")[0]);
        int[,] matrix = ReadMatrix(size, size);

        List<int> spiralValues = GetSpiralTraversalValues(matrix);
        Console.WriteLine(string.Join(" ", spiralValues));
    }

    private static List<int> GetSpiralTraversalValues(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        List<int> values = [];

        int startRow = 0;
        int endRow = rows - 1;
        int startCol = 0;
        int endCol = cols - 1;

        while (startRow <= endRow)
        {
            for (int col = startCol; col <= endCol; col++)
            {
                values.Add(matrix[startRow, col]);
            }

            for (int row = startRow + 1; row <= endRow; row++)
            {
                values.Add(matrix[row, endCol]);
            }

            for (int col = endCol - 1; col >= startCol; col--)
            {
                values.Add(matrix[endRow, col]);
            }

            for (int row = endRow - 1; row > startRow; row--)
            {
                values.Add(matrix[row, startCol]);
            }

            startRow++;
            endRow--;
            startCol++;
            endCol--;

        }

        return values;
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