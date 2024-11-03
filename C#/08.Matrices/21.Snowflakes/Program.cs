
internal class Program
{
    private static void Main(string[] args)
    {
        int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        char[,] matrix = ReadMatrix(sizes[0], sizes[1]);

        GenerateSnowflakeStates(matrix);
    }

    private static void GenerateSnowflakeStates(char[,] matrix)
    {
        char[,] state = matrix;
        string separator = string.Empty;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            separator += "=";
        }

        int firstFlakeRow = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            bool hasNewState = false;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == '*' && state[row + 1, col] != '#')
                {
                    state[row + 1, col] = '*';
                    matrix[row, col] = '0';
                    if (!hasNewState)
                    {
                        firstFlakeRow++;
                    }
                    hasNewState = true;
                }
            }
                        
            if (hasNewState)
            {
                if (firstFlakeRow > 1)
                {
                    Console.WriteLine(separator);
                }

                PrintMatrix(state);                
            }
        }
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