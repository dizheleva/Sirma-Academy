internal class Program
{
    private static void Main(string[] args)
    {
        int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[,] chessboard = ReadMatrix(sizes[0], sizes[1]);

        bool isThreatenedQueen = CheckQueens(chessboard);
        Console.WriteLine(isThreatenedQueen ? "Yes" : "No");
    }

    private static bool CheckQueens(int[,] chessboard)
    {
        bool isThreatened = false;

        if (RowHasQueens(chessboard) || ColumnHasQueens(chessboard) || diagonalHasQueens(chessboard))
        {
            return true;
        }

        return isThreatened;
    }

    private static bool diagonalHasQueens(int[,] chessboard)
    {
        int rows = chessboard.GetLength(0);
        int cols = chessboard.GetLength(1);

        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (chessboard[row, col] == 1)
                {
                    int diagonalLength = rows - row > cols - col ? cols - col - 1 : rows - row - 1;

                    for (int i = 0; i < diagonalLength; i++)
                    {
                        int diagonalRow = row + i + 1;
                        int diagonalCol = col + i + 1;

                        if (chessboard[diagonalRow, diagonalCol] == 1)
                        {
                            return true;
                        }
                    }

                    diagonalLength = row > col ? col : row;

                    for (int j = 0; j < diagonalLength; j++)
                    {
                        int diagonalRow = row + j + 1;
                        int diagonalCol = col - j - 1;

                        if (chessboard[diagonalRow, diagonalCol] == 1)
                        {
                            return true;
                        }
                    }
                }
            }
        }

        return false;
    }
    private static bool ColumnHasQueens(int[,] chessboard)
    {
        for (int col = 0; col < chessboard.GetLength(1); col++)
        {
            int queens = 0;

            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                if (chessboard[row, col] == 1)
                {
                    queens++;
                    if (queens > 1)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    private static bool RowHasQueens(int[,] chessboard)
    {
        for (int row = 0; row < chessboard.GetLength(0); row++)
        {
            int queens = 0;

            for (int col = 0; col < chessboard.GetLength(1); col++)
            {
                if (chessboard[row, col] == 1)
                {
                    queens++;
                    if (queens > 1)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
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