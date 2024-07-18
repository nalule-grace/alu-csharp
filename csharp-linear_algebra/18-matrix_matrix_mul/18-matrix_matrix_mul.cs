/// <summary>
/// Multiplies two matrices and returns the resulting product matrix.
/// </summary>
public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
{
/// <summary>
/// Multiplies two matrices and returns the resulting product matrix.
/// </summary>
/// <param name="matrix1">The first matrix.</param>
/// <param name="matrix2">The second matrix.</param>
/// <returns>The resulting product matrix, or a matrix filled with -1 if the matrices cannot be multiplied.</returns>
    int m1Rows = matrix1.GetLength(0); // Number of rows in matrix1
    int m1Cols = matrix1.GetLength(1); // Number of columns in matrix1
    int m2Rows = matrix2.GetLength(0); // Number of rows in matrix2
    int m2Cols = matrix2.GetLength(1); // Number of columns in matrix2

    // Check if multiplication is possible (number of columns in matrix1 must equal number of rows in matrix2)
    if (m1Cols != m2Rows)
    {
        return new double[m1Rows, m2Cols].Fill(-1); // Return matrix filled with -1 if not multiplicable
    }

    // Initialize the resulting product matrix
    double[,] result = new double[m1Rows, m2Cols];

    // Perform element-wise multiplication for each cell in the resulting matrix
    for (int i = 0; i < m1Rows; i++)
    {
        for (int j = 0; j < m2Cols; j++)
        {
            double sum = 0;
            for (int k = 0; k < m1Cols; k++) // Iterate through corresponding elements
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}