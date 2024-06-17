using MyMath;
namespace MyMath.Tests;

public class Tests
{
    int[,] testMatrix = {{15, 10}, {25,15}};
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Divide_possible(){
        var result = Matrix.Divide(testMatrix, 5);
        int[,] expected = { { 3, 2 }, { 5, 3 } };
        Assert.That(expected, Is.EqualTo(result));
    }
    [Test]
    public void Divide_ByZero_Null()
    {
        var result = Matrix.Divide(testMatrix, 0);
        Assert.IsNull(result);
    }
}    








