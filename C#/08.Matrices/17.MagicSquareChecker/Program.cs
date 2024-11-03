internal class Program
{
    private static void Main(string[] args)
    {
        int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[,] matrix = ReadMatrix(sizes[0], sizes[1]);

        bool isMagic = EqualMatrixSums(matrix);

        Console.WriteLine(isMagic);
    }

    private static bool EqualMatrixSums(int[,] matrix)
    {
        int rowSum = 0;
        int firstDiagonalSum = 0;
        int secondDiagonalSum = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            rowSum = 0;
            int colSum = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                rowSum += matrix[row, col];
                colSum += matrix[col, row];
            }

            firstDiagonalSum += matrix[row, row];            
            secondDiagonalSum += matrix[matrix.GetLength(0) - 1 - row, row];

            if (rowSum != colSum)
            {
                return false;
            }
        }

        if (firstDiagonalSum != secondDiagonalSum || firstDiagonalSum != rowSum)
        {
            return false;
        }

        return true;
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