using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CountSquareTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 3, 4, 5 };
            double result = CountSquare.Program.Count(array);
            Assert.AreEqual(6, result);
        }
    }
}
