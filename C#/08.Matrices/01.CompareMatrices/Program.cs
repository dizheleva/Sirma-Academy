

internal class Program
{
    private static void Main(string[] args)
    {
        int[][] matrixOne = ReadMatrix();        
        int[][] matrixTwo = ReadMatrix();

        bool isEqual = IsMatrixEqual(matrixOne, matrixTwo);

        string result = isEqual ? "equal" : "not equal";
        Console.WriteLine(result);
    }

    private static bool IsMatrixEqual(int[][] matrixOne, int[][] matrixTwo)
    {
        if (matrixOne.Length != matrixTwo.Length || matrixOne[0].Length != matrixTwo[0].Length)
        {
            return false;
        }

        for (int row = 0; row < matrixOne.Length; row++)
        {
            for (int col = 0; col < matrixOne[0].Length; col++)
            {
                if (matrixOne[row][col] != matrixTwo[row][col])
                {
                    return false;
                }
            }
        }

        return true;
    }

    private static int[][] ReadMatrix()
    {
        int[] matrixSizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int rows = matrixSizes[0];
        int cols = matrixSizes[1];

        int[][] matrix = new int[rows][];
        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        }

        return matrix;
    }
}