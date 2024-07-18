public class MatrixMath
{
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