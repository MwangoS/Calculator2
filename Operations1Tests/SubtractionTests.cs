using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 20;
        private readonly int b = 5;
        private readonly double c = 10.1;
        private readonly double d = 2.5;
        private readonly double[] e = { 10.5, 1.0, 2.1 };

        [TestMethod()]
        public void SubtractTest()
        {
            Assert.AreEqual(15, Subtraction.Subtract(a, b));
        }

        [TestMethod()]
        public void SubtractDoubleTest()
        {
            Assert.AreEqual(7.6, Subtraction.Subtract(c, d));
        }

        [TestMethod()]
        public void SubtractDoubleArrayTest()
        {
            Assert.AreEqual(-13.6, Subtraction.Subtract(e));
        }
    }
}