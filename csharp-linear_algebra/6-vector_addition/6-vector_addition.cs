﻿/// <summary>
/// vector addtion
/// </summary>
public class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length || (vector1.Length != 2 && vector1.Length != 3))
        {
        return new double[] { -1, -1, -1 }; // Invalid vectors
        }

        int dimension = vector1.Length;
        double[] result = new double[dimension];

        for (int i = 0; i < dimension; i++)
        {
        result[i] = vector1[i] + vector2[i];
        }

        return result;
    }
}