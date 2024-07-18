
public class MatrixMath
{
    /// <summary>
    /// Applies a 2D shear transformation to a square matrix.
    /// Shearing distorts the matrix along a specified direction (x or y) by a certain factor.
    /// </summary>
    /// <param name="matrix">The 2D square matrix to be sheared.</param>
    /// <param name="direction">The direction of the shear transformation ('x' or 'y').</param>
    /// <param name="factor">The shear factor, which determines the amount of distortion.</param>
    /// <returns>
    /// A new matrix representing the sheared version of the original matrix, 
    /// or a matrix filled with -1 if the input matrix is not square or the direction is invalid.
    /// </returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
        return new double[,] { { -1 } }; // Invalid matrix size (not square)
        }

        if (direction != 'x' && direction != 'y')
        {
        return new double[,] { { -1 } }; // Invalid shear direction
        }

        int dimension = matrix.GetLength(0); // Assuming square matrix
        double[,] result = new double[dimension, dimension];

        for (int row = 0; row < dimension; row++)
        {
        for (int col = 0; col < dimension; col++)
        {
            // Apply shear based on direction
            result[row, col] = matrix[row, col] + (direction == 'x' ? factor * row : factor * col);
        }
        }

        return result;
    }
}