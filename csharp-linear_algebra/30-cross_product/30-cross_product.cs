/// <summary>
/// This class contains methods for performing operations on vectors.
/// </summary>
public class VectorMath
{
     /// <summary>
    /// Calculates the cross product of two 3D vectors.
    /// </summary>
    /// <param name="vector1">The first 3D vector.</param>
    /// <param name="vector2">The second 3D vector.</param>
    /// <returns>
    /// The resulting cross product vector, or a vector filled with -1 if the input vectors are not 3D.
    /// </returns>
    /// <exception cref="ArgumentException">Thrown if either input vector is not of dimension 3.</exception>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
        {
        return new double[] { -1, -1, -1 }; // Invalid vector dimension (not 3D)
        }

        double x = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        double y = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        double z = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        return new double[] { x, y, z };
    }
}