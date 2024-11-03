
internal class Program
{
    private static void Main(string[] args)
    {
        int[] matrixSizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int rows = matrixSizes[0];
        int cols = matrixSizes[1];

        int[,] matrixA = ReadMatrix(rows, cols);
        int[,] matrixB = ReadMatrix(rows, cols);

        int[,] combinedMatrix = CombineMatrices(matrixA, matrixB);

        PrintMatrix(combinedMatrix);
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

    private static int[,] CombineMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);

        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = matrixA[row, col] + matrixB[row, col];
            }
        }

        return matrix;
    }

    private static int[,] ReadMatrix(int rows, int cols)
    {   
        int[,] matrix = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            int[] rowValues = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = rowValues[col];
            }
        }

        return matrix;
    }
}