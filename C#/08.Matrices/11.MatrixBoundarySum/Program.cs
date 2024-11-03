
internal class Program
{
    private static void Main(string[] args)
    {
        int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[,] matrix = ReadMatrix(sizes[0], sizes[1]);

        int sum = SumBoundaries(matrix);
        Console.WriteLine(sum);
    }

    private static int SumBoundaries(int[,] matrix)
    {
        int sum = 0;

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sum += matrix[0, i];
            sum += matrix[matrix.GetLength(0) - 1, i];
        }

        for (int i = 1; i < matrix.GetLength(0) - 1; i++)
        {
            sum += matrix[i, 0];
            sum += matrix[i, matrix.GetLength(1) - 1];
        }

        return sum;
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