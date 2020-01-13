using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basic_Calculator1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Calculator1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.Add(1, 2);

            Assert.AreEqual(3, c);
            Assert.AreEqual(3, calculator.result);

        }
        /*[TestMethod()]

        public void AddIntDoubleTest()
        {
            Calculator calculator = new Calculator();
            int a = 1;
            double b = 2.02;
            double c = calculator.Add(a, b);

            Assert.AreEqual(3.02, c);
            Assert.AreEqual(3.02, calculator.result);

        }*/
    }
}