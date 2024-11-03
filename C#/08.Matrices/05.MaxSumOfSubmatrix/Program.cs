
internal class Program
{
    private static void Main(string[] args)
    {
        int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[,] matrix = ReadMatrix(sizes[0], sizes[1]);

        int submatrixSize = 2;
        int[,] submatrix = new int[submatrixSize, submatrixSize];
        int sum = 0;

        for (int row = 0; row <= matrix.GetLength(0) - submatrixSize; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - submatrixSize; col++)
            {
                int[,] currentSubmatrix = GetSubmatrix(matrix, row, col, submatrixSize);
                int currentSum = SumMatrix(currentSubmatrix);

                if (currentSum >= sum)
                {
                    sum = currentSum;
                    submatrix = currentSubmatrix;
                }
            }
        }

        Console.WriteLine(sum);
        PrintMatrix(submatrix);
    }

    private static int[,] GetSubmatrix(int[,] matrix, int startRow, int startCol, int size)
    {
        int[,] submatrix = new int[size, size];

        for (int row = 0; row < size; row++)
        {            
            for (int col = 0; col < size; col++)
            {
                submatrix[row, col] = matrix[startRow + row, startCol + col];
            }
        }

        return submatrix;
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

    private static int SumMatrix(int[,] matrix)
    {
        int sum = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sum += matrix[row, col];
            }
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