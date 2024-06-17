﻿namespace MyMath;

    ///<summary>
    /// class for matrix operations
    ///</summary>
public class Matrix
{
    ///<summary>
    /// This Method divides a matrix by an int
    ///</summary>
    public static int [,]? Divide(int [,]  matrix, int val) {
        if (matrix == null)
        {
            return null;
        }
        int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
        try
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int div = matrix[i, j] / val;
                    newMatrix[i, j] = div;
                }
            }
        }
        catch (DivideByZeroException)
        {

            Console.WriteLine("value cannot be 0");
            return null;
        }
        return newMatrix;
    }
}
    

