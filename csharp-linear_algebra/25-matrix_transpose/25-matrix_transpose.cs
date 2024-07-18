public class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0 || matrix.GetLength(0) == 0)
        {
        return new double[,] { }; // Empty matrix
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] transposed = new double[cols, rows]; // Reversed dimensions for transpose

        for (int row = 0; row < rows; row++)
        {
        for (int col = 0; col < cols; col++)
        {
            transposed[col, row] = matrix[row, col]; // Swap row and column indices
        }
        }

        return transposed;
    }
}