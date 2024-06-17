using System.Runtime.CompilerServices;
using MyMath;
namespace MyMath.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void With_positive_numbers() {
        List<int> vals = new List<int> {12,5,4,6};
        var result = Operations.Max(vals);
        var expected = 12;
        Assert.That(expected, Is.EqualTo(result));
    }
    [Test]

    public void With_empty_list() {
        List<int> vals = new List<int>();
        var result = Operations.Max(vals);
        var expected = 0;
        Assert.That(expected, Is.EqualTo(result));
    }
}    

