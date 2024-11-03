
internal class Program
{
    private static void Main(string[] args)
    {
        string[] inputData = Console.ReadLine().Split(" ");
        int size = int.Parse(inputData[0]);
        char pattern = char.Parse(inputData[1]);

        int[,] matrix = CreateMatrix(size, pattern);
        PrintMatrix(matrix);
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

    private static int[,] CreateMatrix(int size, char pattern)
    {
        int number = 1;

        int[,] matrix = new int[size, size];
        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                int rowValue = row;
                if (col % 2 != 0 && pattern == 'B')
                {
                    rowValue = size - 1 - row;
                }

                matrix[rowValue, col] = number++;
            }
        }

        return matrix;
    }
}