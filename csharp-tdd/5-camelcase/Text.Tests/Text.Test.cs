using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using NUnit.Framework;
using System;
namespace Text.Tests;

public class CamelCaseTests
{ 
    [TestCase("", 0)] 
    [TestCase(null, 0)] 
    [TestCase("single", 1)] 

    public void TestsCamelCase(string? input, int expected)
    {
        Assert.That(Str.CamelCase(input), Is.EqualTo(expected));
    }
}