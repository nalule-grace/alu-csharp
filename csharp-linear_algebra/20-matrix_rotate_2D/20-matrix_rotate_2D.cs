﻿public class MatrixMath
{
    /// <summary>
/// Rotates a 2D square matrix by a given angle in radians.
/// </summary>
/// <param name="matrix">The 2D square matrix to be rotated.</param>
/// <param name="angle">The rotation angle in radians.</param>
/// <returns>A new rotated matrix, or a matrix containing -1 if the input matrix is not square.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
        return new double[,] { { -1 } }; // Invalid matrix size (not square)
        }

        int dimension = matrix.GetLength(0); // Assuming square matrix
        double[,] result = new double[dimension, dimension];

        // Cosine and sine of the rotation angle
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        for (int row = 0; row < dimension; row++)
        {
        for (int col = 0; col < dimension; col++)
        {
            // Apply rotation transformation to each element
            result[row, col] = matrix[row, col] * cosTheta - matrix[col, row] * sinTheta;
        }
        }

        return result;
    }
}