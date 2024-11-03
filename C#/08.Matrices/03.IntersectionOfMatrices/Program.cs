

internal class Program
{
    private static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        char[,] matrixA = ReadMatrix(rows, cols);
        char[,] matrixB = ReadMatrix(rows, cols);

        char[,] outputMatrix = CombineMatrices(matrixA, matrixB);

        PrintMatrix(outputMatrix);
    }

    private static void PrintMatrix(char[,] matrix)
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

    private static char[,] CombineMatrices(char[,] matrixA, char[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);

        char[,] matrix = new char[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = matrixA[row, col] == matrixB[row, col] ? matrixA[row, col] : '*';
            }
        }

        return matrix;
    }

    private static char[,] ReadMatrix(int rows, int cols)
    {
        char[,] matrix = new char[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            char[] rowValues = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = rowValues[col];
            }
        }

        return matrix;
    }
}