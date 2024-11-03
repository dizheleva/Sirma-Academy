
internal class Program
{
    private static void Main(string[] args)
    {
        int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[,] matrix = ReadMatrix(sizes[0], sizes[1]);

        SetZeros(matrix);

        PrintMatrix(matrix);
    }

    private static void SetZeros(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        List<int> zeroRows = [];
        List<int> zeroCols = [];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (matrix[row, col] == 0)
                {
                    zeroCols.Add(col);
                    zeroRows.Add(row);  
                }
            }
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (zeroCols.Contains(col) || zeroRows.Contains(row))
                {
                    matrix[row, col] = 0;
                }
            }
        }
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