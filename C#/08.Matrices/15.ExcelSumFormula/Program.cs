
internal class Program
{
    private static void Main(string[] args)
    {
        int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[,] matrix = ReadMatrix(sizes[0], sizes[1]);

        string[] cellNames = Console.ReadLine().Split(":");
        string startCellName = cellNames[0];
        string endCellName = cellNames[1];

        int[] startCellIndeces = GetCellIndeces(startCellName);
        int[] endCellIndeces = GetCellIndeces(endCellName);

        int sum = SumMatrixColumns(matrix, startCellIndeces, endCellIndeces);

        Console.WriteLine(sum);
    }

    private static int[] GetCellIndeces(string startCellName)
    {
        int rowNumber = int.Parse(startCellName.Where(char.IsNumber).ToArray()) - 1;
        char[] columnName = startCellName.Where(char.IsLetter).ToArray();
        int columnNumber = 0;

        for (int i = 0; i < columnName.Length; i++)
        {
            int charValue = columnName[columnName.Length - 1 - i] - 'A';
            columnNumber += charValue + 25 * i * charValue;
        }

        return [rowNumber, columnNumber];
    }

    private static int SumMatrixColumns(int[,] matrix, int[] startCell, int[] endCell)
    {
        int sum = 0;

        for (int col = startCell[1]; col < matrix.GetLength(1); col++)
        {
            for (int row = startCell[0]; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row, col];

                if (row == endCell[0] && col == endCell[1])
                {
                    return sum;
                }
            }
        }

        return sum;
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