/// <summary>
///THIS class contains methods for performing vector operations
/// </summary>
public class VectorMath{
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length !=2 && vector.Length !=3){
            return new double[] {-1, -1, -1};
        }
        int dimension = vector.Length;
        double[] result = new double[dimension];

        for (int i = 0; i < dimension; i++)
        {
        result[i] = vector[i] * scalar;
        }

        return result;
    }
}