
internal class Program
{
    private static void Main(string[] args)
    {
        int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[,] matrix = ReadMatrix(sizes[0], sizes[1]);

        int[] rowSums = GetSums(matrix, "row");
        int[] columnSums = GetSums(matrix, "column");

        Console.WriteLine("Row Sums: " + string.Join(", ", rowSums));
        Console.WriteLine("Column Sums: " + string.Join(", ", columnSums));
    }

    private static int[] GetSums(int[,] matrix, string direction)
    {
        int directionLength = direction == "row" ? matrix.GetLength(0) : matrix.GetLength(1);
        int otherDirectionLength = direction == "row" ? matrix.GetLength(1) : matrix.GetLength(0); ;
        int[] sums = new int[directionLength];

        for (int i = 0; i < directionLength; i++)
        {
            int directionSum = 0;
            for (int j = 0; j < otherDirectionLength; j++)
            {
                directionSum += direction == "row" ? matrix[i, j] : matrix[j, i];
            }

            sums[i] = directionSum;
        }

        return sums;
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