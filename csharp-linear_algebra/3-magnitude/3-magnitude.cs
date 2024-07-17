public class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
        return -1; // Invalid vector dimension
        }

        double sum = 0;
        foreach (double element in vector)
        {
        sum += Math.Pow(element, 2); // Square each element
        }

        return Math.Round(Math.Sqrt(sum), 2); // Round to nearest hundredth
    }
}