using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly int a = 5;
        private readonly double b = 2.2;
        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(25, Square.Squared(a));

        }

        public void SquaredDoubleTest()
        {
            Assert.AreEqual(2.84, Square.Squared(b));
        }
    }
}