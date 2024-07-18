/// <summary>
/// This class contains methods for performing operations on matrices.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Calculates the inverse of a 2D square matrix (if it exists).
    /// </summary>
    /// <param name="matrix">The 2D square matrix for which to find the inverse.</param>
    /// <returns>
    /// The inverse matrix, or a matrix filled with -1 if the matrix is not invertible:
    ///  - Matrix is not 2x2 dimensions.
    ///  - Matrix is not invertible (determinant is zero).
    /// </returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
        return new double[,] { { -1 } }; // Invalid matrix dimension (not 2x2)
        }

        double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        if (Math.Abs(determinant) < double.Epsilon)
        {
        return new double[,] { { -1 } }; // Non-invertible matrix (determinant is zero)
        }

        double invDeterminant = 1.0 / determinant;

        double[,] inverse = new double[,] {
        { invDeterminant * matrix[1, 1], -invDeterminant * matrix[0, 1] },
        { -invDeterminant * matrix[1, 0], invDeterminant * matrix[0, 0] }
        };

        return inverse;
    }
}