public class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        int dimension = matrix.GetLength(0);

        if (dimension != 2 && dimension != 3)
        {
        return -1; // Invalid matrix dimension (not 2x2 or 3x3)
        }

        // Base cases for 2x2 and 3x3 matrices
        if (dimension == 2)
        {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else
        {
        double det = 0;
        for (int i = 0; i < dimension; i++)
        {
            // Calculate determinant using recursive calls for sub-matrices
            det += Math.Pow(-1, i) * matrix[0, i] * Determinant(Minor(matrix, 0, i));
        }
        return det;
        }
    }

    private static double[,] Minor(double[,] matrix, int row, int col)
    {
        int dimension = matrix.GetLength(0) - 1;
        double[,] minor = new double[dimension, dimension];

        int minorRow = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
        if (i == row) continue; // Skip the row we're removing

        int minorCol = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == col) continue; // Skip the column we're removing

            minor[minorRow, minorCol] = matrix[i, j];
            minorCol++;
        }
        minorRow++;
        }

        return minor;
    }
}