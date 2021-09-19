using System;
using CountSquare;
using NUnit.Framework;

namespace NUnitTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestNull()
        {
            Assert.Throws<ArgumentNullException>(() => (null as int[]).Count());
        }

        [TestCase(new int[] { 3, 4, 5 }, ExpectedResult = 6)]
        [TestCase(new int[] { 5, 12, 13 }, ExpectedResult = 30)]

        public double TestNotNullTriangleSquare(int[] array)
        {
            double result = array.Count();
            return result;
        }

        [TestCase(new int[] { 3 }, ExpectedResult = 28.274333882308138)]
        [TestCase(new int[] { 5 }, ExpectedResult = 78.53981633974483)]
        public double TestNotNullCircleSquare(int[] array)
        {
            double result = array.Count();
            return result;
        }
    }
}