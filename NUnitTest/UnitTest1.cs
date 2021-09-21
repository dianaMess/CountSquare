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
            bool is_right = false;
            Assert.Throws<ArgumentNullException>(() => (null as int[]).Count(out is_right));
        }
        [TestCase(new int[] { 7, 5, 8 }, ExpectedResult = 17.320508075688775)]
        [TestCase(new int[] { 10, 9, 15 }, ExpectedResult = 43.634848458542855)]
        [TestCase(new int[] { 3, 4, 5 }, ExpectedResult = 6)]
        [TestCase(new int[] { 5, 12, 13 }, ExpectedResult = 30)]

        public double TestNotNullTriangleSquare(int[] array)
        {
            bool is_right = false;
            double result = array.Count(out is_right);
            return result;
        }

        [TestCase(new int[] { 3 }, ExpectedResult = 28.274333882308138)]
        [TestCase(new int[] { 5 }, ExpectedResult = 78.53981633974483)]
        public double TestNotNullCircleSquare(int[] array)
        {
            bool is_right = false;
            double result = array.Count(out is_right);
            return result;
        }
    }
}