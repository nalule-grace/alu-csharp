using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using NUnit.Framework;
using System;

namespace Text.Tests;

    public class UniqueTests
    {
        [TestCase("ffbbdd", -1)] 
        [TestCase("fluffy", 1)] 
        [TestCase("", -1)] 
        public void UniqueChar(string? s, int index)
        {
            Assert.That(index, Is.EqualTo(Text.Str.UniqueChar((s))));
        }
    }